using FoodRestaurnats.Data.Models;
using FoodRestaurnats.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FoodRestaurnats.Controllers {
    //{
    //[Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
      

        public AdministrationController(RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model) {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "administration");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }
          
            return View(model);
                
                    }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        //[Authorize(Policy ="EditRolePolicy")]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model); // This line should be outside the foreach loop
        }

        [HttpPost]
        //[Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={model.Id} canno be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                //update into databse usig updateasync method
                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            //foreach (var user in userManager.Users)
            //{
            //    if (await userManager.IsInRoleAsync(user, role.Name))
            //    {
            //        model.Users.Add(user.UserName);
            //    }
            //}
        }
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId) {
            ViewBag.roleId = roleId;
            var role=await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={roleId} cannot be found";
                return View("NotFound");
            }
            var model=new List<UserRoleViewModel>();

            foreach(var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    userID = user.Id,
                    userName = user.UserName,
                };

                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.isSelected = true;
                }
                else
                {
                    userRoleViewModel.isSelected= false;
                }
                model.Add(userRoleViewModel);
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={roleId} cannot be found";
                return View("NotFound");
            }




            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].userID);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id={model[i].userID} cannot be found";
                    return View("NotFound");
                }

                IdentityResult result = null;

                if (model[i].isSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].isSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                //if (!result.Succeeded)
                //{
                //    // Handle the error, if needed.
                //    // You can return an error view or log the error.
                //}
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }
    }
}

