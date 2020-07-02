using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendingMachine.Dal.Models;
using VendingMachine.Helpers;
using VendingMachine.Models;
using VendingMachine.Services;

namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryHelper _inventoryHelper;
        private readonly IMoneyService _moneyService;
        private readonly IProductService _productService;

        public HomeController(IInventoryHelper inventoryHelper, IMoneyService moneyService, IProductService productService)
        {
            _inventoryHelper = inventoryHelper;
            _moneyService = moneyService;
            _productService = productService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Angie's Inventory.";

            // if models been passed in because it's not the first time ????? IS it possible to go back to HttpGet??
            //if (model != null)
            //{
            //    return View(model);
            //}

            var model = _inventoryHelper.GetInventoryViewModel();

            return View(model);
        }

        /// <summary>
        /// Overall vending machine action
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(VendingMachineViewModel model, int? submitMoney, string submitButton, bool? vend)
        {
            //sumbit could be either wallet sumbit (money) or button press submit 
            //if money submit then 
            if (submitMoney.HasValue)
            {
                //1- validate money
                //2- if money is valid increase either Accepted money or Rejected money in model
                // watchers make animations?
                var money = _moneyService.InsertMoney(model.AcceptedMoney, model.RejectedMoney, submitMoney);
                // add into our view model model
                if (_moneyService.ValidateMoney(submitMoney))
                {
                    model.AcceptedMoney = money.Item1;
                }
                else
                {
                    model.RejectedMoney = money.Item2;
                }             
            }
            else if (submitButton.ToString() != null) // if button was submitted
            {
                // add to buttons pressed, if already 2 in there then delete first and add last return the slot
                var codeAndProductSlot = _productService.InsertButtonPress(model.ButtonsPressed , submitButton);
                model.ButtonsPressed = codeAndProductSlot.Item1;

                //if matches to slot then check 
                if (codeAndProductSlot.Item2 != null)
                {
                    //if enough accepted money vend :D
                    if (codeAndProductSlot.Item2.Product.Price <= model.AcceptedMoney)
                    {
                        //vend and show that it is vending....? HOW
                        //add the product from slot down into the 'push' door (vendedProducts) and remove from the product slots
                        // also in view if the slot not in front must turn the carousel first
                        // ALSO WHAT IF IT'S AN EMPTY PRODUCT?!
                        (List<ProductSlot>, double, List<Product>) vendProduct = _productService.VendProduct(model.ProductSlots, model.AcceptedMoney, model.VendedProducts, model.ButtonsPressed);
                    }
                    else  // if matches to slot but not enough money then do not vend , instead show message
                    {
                        // add message onto screen display that says 'Insert More Money' do this in JS ?? 
                    }
                }
                else //if does not match to slot show message 'Wrong Code, Try Again'
                {
                    //message then clear code
                    model.ButtonsPressed.Clear();
                }               
            }

            return View(model);
        }

        //public PartialViewResult _Wallet()
        //{
        //    var model = _moneyService.GetAllMoney();
        //    return PartialView(model);
        //}
    }
}