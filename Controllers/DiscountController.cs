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
        public async Task<IActionResult> Create(Discount discount)
        {
            _dataContext.AddDiscount(discount);
            return RedirectToAction("Index");
        }
        public ViewResult Create() => View();

        //TODO write logic for delete discount button
        // this method accepts an argument to delete a blog and redirects to the home page
        public IActionResult DeleteDiscount(int id)
        {
           _dataContext.DeleteDiscount(_dataContext.Discounts.FirstOrDefault(b => b.DiscountId == id));
            return RedirectToAction("Index");
        }
     
     

        //TODO write logic for edit discount button
        [HttpPost]
        public async Task<IActionResult> Edit(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();

            // add edit logic here
            return null;
        }


        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
