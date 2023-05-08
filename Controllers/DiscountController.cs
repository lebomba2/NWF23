using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Linq;



namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private DataContext _dataContext;
        private RoleManager<IdentityRole> roleManager;
        public DiscountController(DataContext db, RoleManager<IdentityRole> roleMgr)
        {
            _dataContext = db;
            roleManager = roleMgr;
        }

        public IActionResult Index() => View(_dataContext.Discounts);

        //TODO use auth decorator and write logic for add discount button
        [HttpPost]
        public IActionResult Create(Discount discount)
        {
            _dataContext.AddDiscount(discount);
            return RedirectToAction("Index");
        }

        //TO DO add appropriate decorators for the method
        //TO DO add logic for create
        public ViewResult Create() => View();

        //TO DO write logic for delete discount button
        //TO DO add appropriate decorators for the method
        // this method accepts an argument to delete a blog and redirects to the home page
        public IActionResult DeleteDiscount(int id)
        {
            _dataContext.DeleteDiscount(_dataContext.Discounts.FirstOrDefault(b => b.DiscountId == id));
            return RedirectToAction("Index");
        }



        public IActionResult Edit(int id) => View(_dataContext.Discounts.FirstOrDefault(d => d.DiscountId == id));

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(Discount discount)
        {
            // Edit discount info
            _dataContext.EditDiscount(discount);
            return RedirectToAction("Index", "Discount");
        }


        //[Authorize(Roles = "northwind-customer"), HttpPost, ValidateAntiForgeryToken]
        //[HttpPost, ValidateAntiForgeryToken]
        //public IActionResult Edit(Discount discount)
        //{
        //    Edit discountr info
        //    _dataContext.EditDiscount(Discount);
        //    return RedirectToAction("Index", "Home");
        //}



        //TO DO write logic for edit discount button
        //[HttpPost]

        //public async Task<IActionResult> Edit(int id)
        // {
        //AppUser user = await userManager.FindByIdAsync(id);
        //if (user != null)
        //{
        //    return View(user);
        //}
        //else
        //{
        //    return RedirectToAction("Index");
        //}
        //return null; //TO DO delete this return statement when logic is written
        //}


        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
