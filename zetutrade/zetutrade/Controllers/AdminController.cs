using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using zetutrade.Helpers;
using zetutrade_DataAccess.Data;
using zetutrade_Model.Models;

namespace zetutrade.Controllers
{
    public class AdminController : Controller
    {        
        private readonly ApplicationDbContext _db;
        public AdminController (ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.Products = (from s in _db.Products
                            select s).Count();

            ViewBag.Blogs = (from s in _db.Blogs
                                select s).Count();

            ViewBag.Orders = (from s in _db.Orders
                                select s).Count();

            ViewBag.ToBePublished = (from s in _db.Blogs
                                     where s.releasetime > DateTime.Now
                                     select s).Count();

            ViewBag.Offers = (from s in _db.Offers
                                select s).Count();

            ViewBag.NewOffers = (from s in _db.Offers
                                 where s.statusID == 1
                              select s).Count();

            ViewBag.GivenOffers = (from s in _db.Offers
                                 where s.statusID == 2
                                 select s).Count();

            ViewBag.ApprovedOffers = (from s in _db.Offers
                                 where s.statusID == 3
                                 select s).Count();

            ViewBag.PreparedOffers = (from s in _db.Offers
                                 where s.statusID == 4
                                 select s).Count();

            ViewBag.CompletedOffers = (from s in _db.Offers
                                 where s.statusID == 5
                                 select s).Count();

            ViewBag.Messages = (from s in _db.Contacts
                                 
                                select s).Count();

            ViewBag.UnreadedMessages = (from s in _db.Contacts
                                     where s.status == 1
                                     select s).Count();

            ViewBag.ReadedMessages = (from s in _db.Contacts
                                     where s.status == 2
                                     select s).Count();

            return View();
        }
        public IActionResult Product()
        {         
            var productlist = _db.Products.Include(a => a.Category).Include(a => a.Category.CategoryTexts).Include(a=> a.ProductTexts.Where(s => s.Language == "tr-TR")).ToList();            
            return View(productlist);
        }
        [HttpPost]  
        public IActionResult AddProduct(string productName, string productDescription, IFormFile productPhotoUrl, bool isinstock, int categoryID)
        {
            var seourl = string.IsNullOrEmpty(productName.Trim()) ? Utility.UrlSeo(productName.Trim()) : Utility.UrlSeo(productName.Trim());
            var add = new Product
            {                
                createtime = DateTime.Now,
                updatetime = DateTime.Now,
                categoryID = categoryID,
                userID = 1,              
                isinstock = isinstock,
            };

            if(productPhotoUrl != null)
            {
                var image = Request.Form.Files[0];
                var filename = Path.GetExtension(productPhotoUrl.FileName);
                var newimagename = "ProductPic_" +seourl+ DateTime.Now.Ticks + filename;            
                var uploadpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/Photos/Product/" + newimagename);
                using(var fileStream = new FileStream(uploadpath, FileMode.Create))
                {
                    //var image = Image.Load(fileStream);
                    productPhotoUrl.CopyTo(fileStream);
                }
                var dbpath = "Photos/Product/" + newimagename;
                add.productPhotoUrl = dbpath;
            }
            _db.Products.Add(add);
            _db.SaveChanges();

            var textadd = new ProductText
            {
                productName = productName,
                productDescription = productDescription,
                productID = add.productID,
                url = seourl,
                Language = "tr-TR"
            };
            _db.ProductTexts.Add(textadd);
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        public IActionResult DeleteProduct(int id)
        {
            var producttext = _db.ProductTexts.Where(a => a.productID == id).ToList();
            _db.ProductTexts.RemoveRange(producttext);
            var product = _db.Products.FirstOrDefault(a => a.productID == id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        [HttpPost]
        public IActionResult AddCategory(string categoryName)
        {
            var add = new Category
            {
                createtime = DateTime.Now,
            };
            _db.Categories.Add(add);
            _db.SaveChanges();

            var textadd = new CategoryText
            {
                categoryID = add.categoryID,
                categoryName = categoryName,
                Language = "tr-TR"
            };
            _db.categoryTexts.Add(textadd);
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        public IActionResult DeleteCategory(int id)
        {
            var cattext = _db.categoryTexts.Where(a => a.categoryID == id).ToList();
            _db.categoryTexts.RemoveRange(cattext);
            var cat = _db.Categories.FirstOrDefault(a => a.categoryID == id);
            _db.Categories.Remove(cat);         
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {

            var category = _db.categoryTexts.FirstOrDefault(a => a.categoryID == id && a.Language == "tr-TR");
            if(category != null)
            {
                ViewBag.update = TempData["update"];
                return View(category);
            }
            return RedirectToAction(nameof(Product));
        }
        [HttpGet]
        public IActionResult UpdateCategoryTextEN(int id)
        {
            var categorytext = _db.categoryTexts.Where(x => x.categoryID == id && x.Language == "en-US").FirstOrDefault();
            if(categorytext == null)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                return View(categorytext);
            }
            
        }
        [HttpGet]
        public IActionResult UpdateCategoryTextESP(int id)
        {
            var categorytext = _db.categoryTexts.Where(x => x.categoryID == id && x.Language == "es-ES").FirstOrDefault();
            if (categorytext == null)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                return View(categorytext);
            }
        }
        [HttpGet]
        public IActionResult UpdateCategoryTextARP(int id)
        {
            var categorytext = _db.categoryTexts.Where(x => x.categoryID == id && x.Language == "ar-AE").FirstOrDefault();
            if (categorytext == null)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                return View(categorytext);
            }
        }
        [HttpPost]
        public IActionResult UpdateCategory(CategoryText d)
        {
            var cat = _db.categoryTexts.FirstOrDefault(a => a.categoryTextID == d.categoryTextID);
            cat.categoryName = d.categoryName;
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _db.Products.Include(a => a.Category).Include(a => a.ProductTexts.Where(s => s.Language == "tr-TR")).FirstOrDefault(a => a.productID == id);
            if (product != null)
            {
                List<SelectListItem> categorylist = (from i in _db.Categories
                                                     join ct in _db.categoryTexts on i.categoryID equals ct.categoryID
                                                     where ct.Language == "tr-TR"
                                                     select new SelectListItem
                                                     {
                                                         Text = ct.categoryName,
                                                         Value = i.categoryID.ToString()
                                                     }).ToList();


                ViewBag.categories = categorylist;
                ViewBag.path = product.productPhotoUrl;
                ViewBag.update = TempData["update"];
                return View(product);
            }
            return RedirectToAction(nameof(Product));
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p, IFormFile productPhotoUrl)
        {
            
            var product = _db.Products.FirstOrDefault(a => a.productID == p.productID);                  
            product.isinstock = p.isinstock;
            product.updatetime = DateTime.Now;
            product.categoryID = p.categoryID;
            if (productPhotoUrl != null)
            {
                var image = Request.Form.Files[0];
                var filename = Path.GetExtension(productPhotoUrl.FileName);
                var newimagename = "ProductPic_" + DateTime.Now.Ticks + filename;
                var uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Photos/Product/" + newimagename);
                using (var fileStream = new FileStream(uploadpath, FileMode.Create))
                {
                    //var image = Image.Load(fileStream);
                    productPhotoUrl.CopyTo(fileStream);
                }
                var dbpath = "Photos/Product/" + newimagename;
                product.productPhotoUrl = dbpath;
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Product));
        }
        [HttpGet]
        public IActionResult UpdateProductTextTR(int id)
        {          
            var producttext = _db.ProductTexts.Where(x => x.productID == id && x.Language == "tr-TR").FirstOrDefault();
            return View(producttext);
        }
        [HttpGet]
        public IActionResult UpdateProductTextEN(int id)
        {
            var producttext = _db.ProductTexts.Where(x => x.productID == id && x.Language == "en-US").FirstOrDefault();
            if(producttext != null)
            {
                return View(producttext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            
        }
        [HttpGet]
        public IActionResult UpdateProductTextESP(int id)
        {
            var producttext = _db.ProductTexts.Where(x => x.productID == id && x.Language == "es-ES").FirstOrDefault();
            if (producttext != null)
            {
                return View(producttext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpGet]
        public IActionResult UpdateProductTextARP(int id)
        {
            var producttext = _db.ProductTexts.Where(x => x.productID == id && x.Language == "ar-AE").FirstOrDefault();
            if (producttext != null)
            {
                return View(producttext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpGet]
        public IActionResult TextAddProduct(int id)
        {
            var product = _db.Products.FirstOrDefault(a => a.productID == id);
            if(product == null)
            {
                return RedirectToAction(nameof(Product));
            }
            ViewBag.update = TempData["update"];
            return View(product);
        }
        [HttpPost]
        public IActionResult TextAddProduct(string Language, string productName, string productDescription, int productID)
        {

            var textcheck = (from x in _db.ProductTexts
                             where x.productID == productID &&
                             x.Language == Language
                             select x).Count();
            if (textcheck > 0)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                var seourl = string.IsNullOrEmpty(productName.Trim()) ? Utility.UrlSeo(productName.Trim()) : Utility.UrlSeo(productName.Trim());
                var textadd = new ProductText
                {
                    productName = productName,
                    productDescription = productDescription,
                    productID = productID,
                    url = seourl,
                    Language = Language,
                };
                _db.ProductTexts.Add(textadd);
                _db.SaveChanges();
                return RedirectToAction(nameof(Product));
            }
            
        }
        [HttpGet]
        public IActionResult TextAddCategory(int id)
        {
            var cat = _db.Categories.FirstOrDefault(a => a.categoryID == id);
            if (cat == null)
            {
                return RedirectToAction(nameof(Product));
            }
            ViewBag.update = TempData["update"];
            return View(cat);
        }
        [HttpPost]
        public IActionResult TextAddCategory(string Language, string categoryName, int categoryID)
        {
            var textcheck = (from x in _db.categoryTexts
                            where x.categoryID == categoryID &&
                            x.Language == Language
                            select x).Count();
            if(textcheck > 0)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                var textadd = new CategoryText
                {
                    categoryName = categoryName,
                    categoryID = categoryID,
                    Language = Language,
                };
                _db.categoryTexts.Add(textadd);
                _db.SaveChanges();
                return RedirectToAction(nameof(Product));
            }
                             
            
        }
        [HttpPost]
        public IActionResult UpdateProductText(ProductText p)
        {
            var seourl = string.IsNullOrEmpty(p.productName.Trim()) ? Utility.UrlSeo(p.productName.Trim()) : Utility.UrlSeo(p.productName.Trim());
            var producttext = _db.ProductTexts.Where(x => x.productTextID == p.productTextID).FirstOrDefault();
            if(producttext != null)
            {
                producttext.productName = p.productName;
                producttext.productDescription = p.productDescription;
                producttext.url = seourl;
                _db.SaveChanges();
                return RedirectToAction(nameof(Product));
            }
            else
            {        
                return RedirectToAction(nameof(Product));
            }
            
        }
        public IActionResult Users()
        {
            ViewBag.email = TempData["email"];
            var users = _db.Users.Include(a => a.userRole).ToList();
            return View(users);
        }
        public IActionResult DeleteUser(int id)
        {
            var user = _db.Users.FirstOrDefault(a => a.userID == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction(nameof(Users));
        }
        [HttpPost]
        public IActionResult AddUser(string userName, string userSurname, string userEmail, string userPassword)
        {
            var email = _db.Users.FirstOrDefault(a => a.userEmail == userEmail);
            if(email != null)
            {
                TempData["email"] = string.Format("no");
                return RedirectToAction(nameof(Users));
            }
            else
            {
                var add = new User
                {
                    userName = userName,
                    userSurname = userSurname,
                    userPassword = userPassword,
                    userEmail = userEmail,
                    userRoleID = 3,
                };
                _db.Users.Add(add);
                _db.SaveChanges();
                return RedirectToAction(nameof(Users));
            }

            
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var user = _db.Users.FirstOrDefault(a => a.userID == id);
            if (user != null)
            {
                List<SelectListItem> rolelist = (from i in _db.UserRoles.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = i.roleName,
                                                         Value = i.userRoleID.ToString()
                                                     }).ToList();
                ViewBag.roles = rolelist;     
                return View(user);
            }
            return RedirectToAction(nameof(Users));
        }
        public IActionResult UpdateUser(User u)
        {
           var user = _db.Users.FirstOrDefault(a => a.userID == u.userID);
            user.userName = u.userName;
            user.userSurname = u.userSurname;
            user.userRoleID = u.userRoleID;
            user.userEmail = u.userEmail;
            user.userPassword = u.userPassword;         
            _db.SaveChanges();
            return RedirectToAction(nameof(Users));
        }
        public IActionResult Customer()
        {
            var customers = _db.Subscribers.ToList();          
            return View(customers);
        }
        public IActionResult DeleteSubscribers(int id)
        {
            var subs = _db.Subscribers.FirstOrDefault(a => a.subsID == id);
            _db.Subscribers.Remove(subs);
            _db.SaveChanges();
            return RedirectToAction(nameof(Customer));
        }
        public IActionResult Orders()
        {
           //var orderlist = _db.Orders.Include(a => a.Product).ToList();
            var orderlist = (from x in _db.Orders
                             
                             orderby x.ordertime descending                            
                             select x
                             ).Include(a => a.Product.ProductTexts).ToList();

           
           return View(orderlist);
        }       
        public IActionResult DeleteOrder(int id)
        {
            var subs = _db.Orders.FirstOrDefault(a => a.orderID == id);
            _db.Orders.Remove(subs);
            _db.SaveChanges();
            return RedirectToAction(nameof(Orders));
        }
        public IActionResult ShowOrder(int id)
        {
            var order = _db.Orders.Include(a => a.Product.ProductTexts).FirstOrDefault(x=> x.orderID == id);
            var productname = _db.ProductTexts.FirstOrDefault(x => x.productID == order.productID && x.Language == "tr-TR");
            ViewBag.productname = productname.productName.ToString();
            return View(order);
        }
        [HttpPost]
        public IActionResult NewOffer(int orderID, double productPrice, double shippingPrice, double discount, int orderNumber)
        {
            var producttotalprice = orderNumber * productPrice;
            var calculateddiscount = (producttotalprice * discount) / 100;
            var add = new Offer
            {
                productPrice = productPrice,
                productTotalPrice = producttotalprice,
                shippingPrice = shippingPrice,
                orderID = orderID,
                statusID = 1               
            };         
            if(discount != null)
            {
                add.discount = calculateddiscount;
            }
            add.offerTotalPrice = producttotalprice + shippingPrice - calculateddiscount;
            _db.Offers.Add(add);
            _db.SaveChanges();
            return RedirectToAction(nameof(Offers));

        }
        public IActionResult Offers()
        {
            var offerlist = (from x in _db.Offers           
                             orderby x.offerID descending
                             select x
                             ).Include(a => a.Order).Include(a => a.Status).ToList();
            return View(offerlist);
        }
        public IActionResult DeleteOffer(int id)
        {
            var offer = _db.Offers.FirstOrDefault(a => a.offerID == id);
            _db.Offers.Remove(offer);
            _db.SaveChanges();
            return RedirectToAction(nameof(Offers));
        }
        public IActionResult ShowOffer(int id)
        {
            ViewBag.producterror = TempData["producterror"];
            var offer = _db.Offers.Include(a => a.Order)
                .Include(a => a.Status).Include(y => y.Order.Product).FirstOrDefault(x => x.offerID == id);
            var order = _db.Orders.FirstOrDefault(x => x.orderID == offer.orderID);
            var productname = _db.ProductTexts.FirstOrDefault(x => x.productID == order.productID && x.Language == "tr-TR");
            ViewBag.productname = productname.productName.ToString();
            return View(offer);
        }
        public IActionResult StatusUp(int id)
        {
            var offer = _db.Offers.FirstOrDefault(x => x.offerID == id);
            offer.statusID += 1;
            _db.SaveChanges();
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
        }
        public IActionResult StatusDown(int id)
        {
            var offer = _db.Offers.FirstOrDefault(x => x.offerID == id);
            offer.statusID -= 1;
            _db.SaveChanges();
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
        }
        public IActionResult OfferPdf(int id)
        {
            var offer = _db.Offers.Include(a => a.Order)
                .Include(a => a.Status).Include(y => y.Order.Product).FirstOrDefault(x => x.offerID == id);
            var witoutdiscount = offer.shippingPrice + offer.productTotalPrice;
            var order = _db.Orders.FirstOrDefault(x => x.orderID == offer.orderID);
            var product = _db.ProductTexts.FirstOrDefault(x => x.Language == "en-US" && x.productID == order.productID);
            if(product == null)
            {
                TempData["producterror"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else {

                var productname = product.productName.ToString();

                var html = "<br><img src='~/Photos/zetulogo.png' style='height:50px'><br>" +
                    "<h1 style='text-align:center; color:#83880F;'>Zetu Trade</h1>" +
                    "<h2 style='text-align:center;'>Zetu Trade Price Offer</h2>" +
                    "<h4 style='text-align:center; color:#83880F;'>" + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + "</h4>" +
                    "<br> <h3 style='text-align:center;'>Name Surname: " + offer.Order.orderNameSurname +
                    "<br> E-Mail: " + offer.Order.orderEmail +
                    "<br> Address: " + offer.Order.orderAddress +
                    "<br><br><hr><br>" +

                    "<br> Product Name : " + productname +
                    "<br> Number Of Product : " + offer.Order.orderNumber +
                    "<br> Price Of The Product (Per pruduct): " + "$" + offer.productPrice +
                    "<br><br><hr><br>" +
                    "<br> Total Cost Of The Product: " + "$" + offer.productTotalPrice +
                    "<br>Shipping Fee: " + "$" + offer.shippingPrice +
                    "<br>Discount: " + "$" + offer.discount +
                    "<br> Total Price Without Discount: $<s>" + witoutdiscount + "</s>" +
                     "<br> +______________________________________" +
                    "<br> Price Of The Offer: <span style='color:#880F51;'>" + "$" + offer.offerTotalPrice + "</span>" +
                    "<br><br><br>" +
                    "You can contact us on <a href='mailto:info@zetutrade.com'>info@zetutrade.com</a> regarding this offer." +
                    "<br><br><br><br><br><span style='color:#353527;'> ZETU İthalat İhracat ve Dış Ticaret Ltd Şti" +
                    "<br><a href='https://www.zetutrade.com/'>zetutrade.com</a><span>" +
                    "</h3>";
                HtmlToPdf oHtmlToPdf = new HtmlToPdf();
                PdfDocument opdfDocument = oHtmlToPdf.ConvertHtmlString(html);
                byte[] pdf = opdfDocument.Save();
                opdfDocument.Close();
                return File(
                    pdf,
                    "application/pdf",
                    offer.Order.orderNameSurname + "_Zetu_Trade_Offer.pdf");
            }
            
        }
        public ActionResult OfferEmail(int id)
        {
            var offer = _db.Offers.Include(a => a.Order)
                 .Include(a => a.Status).Include(y => y.Order.Product).FirstOrDefault(x => x.offerID == id);
            var witoutdiscount = offer.shippingPrice + offer.productTotalPrice;
            var order = _db.Orders.FirstOrDefault(x => x.orderID == offer.orderID);
            var product = _db.ProductTexts.FirstOrDefault(x => x.Language == "en-US" && x.productID == order.productID);
            var productname = product.productName.ToString();
            
            if (offer != null)
            {
                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 465);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("admin@zetutrade.com", "Zetu Trade Price Offer");
                mail.To.Add(offer.Order.orderEmail);
                mail.IsBodyHtml = true;
                mail.Subject = "Zetu Trade Offer ";
                mail.Body += "<br><br><h1 style='text-align:center; color:#83880F;'>Zetu Trade</h1>" +
                "<h2 style='text-align:center;'>Zetu Trade Price Offer</h2>" +
                "<h4 style='text-align:center; color:#83880F;'>" + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + "</h4>" +
                "<br> <h3 style='text-align:center;'>Name Surname: " + offer.Order.orderNameSurname +
                "<br> E-Mail: " + offer.Order.orderEmail +
                "<br> Address: " + offer.Order.orderAddress +
                "<br><br><hr><br>" +
                
                "<br> Product Name : " + productname +
                "<br> Number Of Product : " + offer.Order.orderNumber +
                "<br> Price Of The Product (Per pruduct): " + "$" + offer.productPrice +
                "<br><br><hr><br>" +
                "<br> Total Cost Of The Product: " + "$" + offer.productTotalPrice +
                "<br>Shipping Fee: " + "$" + offer.shippingPrice +
                "<br>Discount: " + "$" + offer.discount +
                "<br> Total Price Without Discount: $<s>" + witoutdiscount + "</s>" +
                 "<br> +______________________________________" +
                "<br> Price Of The Offer: <span style='color:#880F51;'>" + "$" + offer.offerTotalPrice + "</span>" +
                "<br><br><br>" +
                "You can contact us on <a href='mailto:info@zetutrade.com'>info@zetutrade.com</a> regarding this offer." +
                "<br><br><br><br><br><span style='color:#353527;'> ZETU İthalat İhracat ve Dış Ticaret Ltd Şti" +
                "<br><a href='https://www.zetutrade.com/'>zetutrade.com</a><span>" +
                "" +
                "" +
                "" +
                "</h3>";

                NetworkCredential net = new NetworkCredential("admin@zetutrade.com", "xzywmmrjivcnjqyb");
                client.Credentials = net;
                client.Send(mail);

                return RedirectToAction(nameof(Offers));

            }
            else
            {
                var HataMesaji = " Girmiş olduğunuz E-posta sistemimizde kayıtlı değil.";
                ViewBag.mesaj = HataMesaji;
                return View();
            }
        }
        public IActionResult Blog()
        {
            var blogList = (from x in _db.Blogs
                             orderby x.releasetime descending
                             select x
                               ).Include(a=> a.BlogTexts.Where(x=> x.Language == "tr-TR")).ToList();
            return View(blogList);

        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(string blogTitle, string blogSpotText, string blogDescription, string releasetime, IFormFile blogPhoto)
        {
            var seourl = string.IsNullOrEmpty(blogTitle.Trim()) ? Utility.UrlSeo(blogTitle.Trim()) : Utility.UrlSeo(blogTitle.Trim());
            string zaman = releasetime;
            var add = new Blog
            {                
                blogviews = 1,
                releasetime = Convert.ToDateTime(zaman)
            };
            if (blogPhoto != null)
            {
                var image = Request.Form.Files[0];
                var filename = Path.GetExtension(blogPhoto.FileName);
                var newimagename = "BlogPic_" + DateTime.Now.Ticks + filename;
                var uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Photos/Product/" + newimagename);
                using (var fileStream = new FileStream(uploadpath, FileMode.Create))
                {
                    //var image = Image.Load(fileStream);
                    blogPhoto.CopyTo(fileStream);
                }
                var dbpath = "Photos/Product/" + newimagename;
                add.blogPhoto = dbpath;
            }
            _db.Blogs.Add(add);
            _db.SaveChanges();
            var blogTexts = new BlogText
            {
                blogTitle = blogTitle,
                blogSpotText = blogSpotText,
                blogDescription = blogDescription,
                url = seourl,
                blogID = add.blogID,
                Language = "tr-TR"
            };
            _db.BlogTexts.Add(blogTexts);
            _db.SaveChanges();
            return RedirectToAction("Blog","Admin");
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogpost = _db.Blogs.Find(id);
            var blogtext = _db.BlogTexts.Where(a => a.blogID == id).ToList();
            _db.BlogTexts.RemoveRange(blogtext);
            _db.Blogs.Remove(blogpost);
            _db.SaveChanges();
            return RedirectToAction(nameof(Blog));
        }
        [HttpGet]
        public IActionResult TextAddBlog(int id)
        {
            var blog = _db.Blogs.FirstOrDefault(a => a.blogID == id);
            if (blog == null)
            {
                return RedirectToAction(nameof(Blog));
            }
            ViewBag.update = TempData["update"];
            return View(blog);
        }
        [HttpPost]
        public IActionResult TextAddBlog(string blogTitle, string blogSpotText, string blogDescription, int blogID, string Language)
        {
            var textcheck = (from x in _db.BlogTexts
                             where x.blogID == blogID &&
                             x.Language == Language
                             select x).Count();
            if(textcheck > 0)
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                var seourl = string.IsNullOrEmpty(blogTitle.Trim()) ? Utility.UrlSeo(blogTitle.Trim()) : Utility.UrlSeo(blogTitle.Trim());
                var blogTexts = new BlogText
                {
                    blogTitle = blogTitle,
                    blogSpotText = blogSpotText,
                    blogDescription = blogDescription,
                    url = seourl,
                    blogID = blogID,
                    Language = Language
                };
                _db.BlogTexts.Add(blogTexts);
                _db.SaveChanges();
                return RedirectToAction("Blog", "Admin");
            }
        }
        [HttpGet]
        public IActionResult UpdateBlog (int id)
        {
            var blog = _db.Blogs.Include(a => a.BlogTexts.Where(s => s.Language == "TR-tr")).FirstOrDefault(a => a.blogID == id);
            if (blog != null)
            {
                ViewBag.update = TempData["update"];
                return View(blog);
            }
            return RedirectToAction(nameof(Product));

        }
        [HttpGet]
        public IActionResult UpdateBlogTextTR(int id)
        {
            var blogtext = _db.BlogTexts.Where(x => x.blogID == id && x.Language == "tr-TR").FirstOrDefault();
            if (blogtext != null)
            {
                return View(blogtext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpGet]
        public IActionResult UpdateBlogTextEN(int id)
        {
            var blogtext = _db.BlogTexts.Where(x => x.blogID == id && x.Language == "en-US").FirstOrDefault();
            if (blogtext != null)
            {
                return View(blogtext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpGet]
        public IActionResult UpdateBlogTextESP(int id)
        {
            var blogtext = _db.BlogTexts.Where(x => x.blogID == id && x.Language == "es-ES").FirstOrDefault();
            if (blogtext != null)
            {
                return View(blogtext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpGet]
        public IActionResult UpdateBlogTextARP(int id)
        {
            var blogtext = _db.BlogTexts.Where(x => x.blogID == id && x.Language == "ar-AE").FirstOrDefault();
            if (blogtext != null)
            {
                return View(blogtext);
            }
            else
            {
                TempData["update"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        [HttpPost]
        public IActionResult UpdateBlogText(BlogText p)
        {
            var seourl = string.IsNullOrEmpty(p.blogTitle.Trim()) ? Utility.UrlSeo(p.blogTitle.Trim()) : Utility.UrlSeo(p.blogTitle.Trim());
            var blogtext = _db.BlogTexts.Where(x => x.BlogTextID == p.BlogTextID).FirstOrDefault();
            if (blogtext != null)
            {
                blogtext.blogTitle = p.blogTitle;
                blogtext.blogDescription = p.blogDescription;
                blogtext.blogSpotText = p.blogSpotText;
                blogtext.url = seourl;
                
                
                _db.SaveChanges();
                return RedirectToAction(nameof(Blog));
            }
            else
            {
                return RedirectToAction(nameof(Blog));
            }
        }
        public IActionResult Messages()
        {
            var messages = (from s in _db.Contacts
                            orderby s.createtime descending
                            select s).ToList();
            return View(messages);
        }
        public IActionResult ReadMessage(int id)
        {
            var message = _db.Contacts.FirstOrDefault(a => a.contactID == id);
            message.status = 2;
            _db.SaveChanges();
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());

        }
        public IActionResult UnReadMessage(int id)
        {
            var message = _db.Contacts.FirstOrDefault(a => a.contactID == id);
            message.status = 1;
            _db.SaveChanges();
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());

        }
        public IActionResult DeleteMessage(int id)
        {
            var message = _db.Contacts.FirstOrDefault(a=> a.contactID == id);
            _db.Contacts.Remove(message);
            _db.SaveChanges();
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());

        }

        //public IActionResult SearchProduct(string searchkey)
        //{
        //    var producttext = from x in _db.ProductTexts
        //                      select x;
         
        //    if (!String.IsNullOrEmpty(searchkey))
        //    {
        //        producttext = producttext.Where(s => s.productName.Contains(searchkey)
        //       || s.productDescription.Contains(searchkey)
        //       );
        //    }

        //    var products = (from s in _db.Products
        //                    where s.productID == Found.productID
        //                    select s);

        //    ViewBag.Word = searchkey;
        //    return View(producttext.ToList());


        //}

    }
}
