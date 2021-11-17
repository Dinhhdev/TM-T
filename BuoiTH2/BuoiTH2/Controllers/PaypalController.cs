using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayPal.Api;
using BuoiTH2.helper;

namespace BuoiTH2.Controllers
{
    public class PaypalController : Controller
    {
        // GET: Paypal
        private PayPal.Api.Payment payment;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PaymentWithPaypal()
        {
            //getting the apiContext as earlier 
            APIContext apiContext = Configuration.GetAPIContext();

            try
            {
                string payerId = Request.Params["PayerID"];

                if (string.IsNullOrEmpty(payerId))
                {
                    
                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority
+
                                "/Paypal/PaymentWithPayPal?";

                    


                    var guid = Convert.ToString((new Random()).Next(100000));

               

                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid);
                    var links = createdPayment.links.GetEnumerator();

                    string paypalRedirectUrl = null;

                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;

                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                           
                         paypalRedirectUrl = lnk.href;
                        }
                    }

                    // saving the paymentID in the key guid 
                    Session.Add(guid, createdPayment.id);

                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    var guid = Request.Params["guid"];

                    var executedPayment = ExecutePayment(apiContext, payerId,
Session[guid] as string);

                    if (executedPayment.state.ToLower() != "approved")
                    {
                        return View("FailureView");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error" + ex.Message);
                return View("FailureView");
            }

            return View("SuccessView");
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {
            {

                var itemList = new ItemList() { items = new List<Item>() };
                //Các giá trị bao gồm danh sách sản phẩm, thông tin đơn hàng 
                //Sẽ được thay đổi bằng hành vi thao tác mua hàng trên website 

                itemList.items.Add(new Item()
                {
                    //Thông tin đơn hàng 
                    name = "Item Name",
                    currency = "USD",
                    price = "5",
                    quantity = "1",
                    sku = "sku"
                });
                //Hình thức thanh toán qua paypal 
                var payer = new Payer() { payment_method = "paypal" };

                // Configure Redirect Urls here with RedirectUrls object 
                var redirUrls = new RedirectUrls()
                {
                    cancel_url = redirectUrl,
                    return_url = redirectUrl
                };
                //các thông tin trong đơn hàng 
                var details = new Details()
                {
                    tax = "1",
                    shipping = "1",
                    subtotal = "5"
                };
                //Đơn vị tiền tệ và tổng đơn hàng cần thanh toán 
                var amount = new Amount()
                {
                    currency = "USD",
                    total = "7", // Total must be equal to sum of shipping, tax and 
                    
                    details = details
                };

                var transactionList = new List<Transaction>();
                //Tất cả thông tin thanh toán cần đưa vào transaction 
                transactionList.Add(new Transaction()
                {
                    description = "Transaction description.",
                    invoice_number = Guid.NewGuid().ToString(),
                    amount = amount,
                    item_list = itemList
                });

                this.payment = new Payment()
                {
                    intent = "sale",
                    payer = payer,
                    transactions = transactionList,
                    redirect_urls = redirUrls
                };
                // Create a payment using a APIContext 
                return this.payment.Create(apiContext);
            }
        }
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution() { payer_id = payerId };
            this.payment = new Payment() { id = paymentId };
            return this.payment.Execute(apiContext, paymentExecution);
        }
    }
            
}
      
