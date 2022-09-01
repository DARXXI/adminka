using AdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = Context.Users.OrderByDescending(t => t.DateCreated).ToArray();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id, CancellationToken cancellationToken)
        {
            ViewBag.Roles = Context.Roles.ToArray();
            var user = id !=null ? await Context.Users.FindAsync(new object?[] { id }, cancellationToken) : new User();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                if (user.Id == 0)
                    user.DateCreated = currentData;
                user.DateUpdated = currentData;
                Context.Users.Update(user);
                await Context.SaveChangesAsync(cancellationToken);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpDelete]
        public async Task Delete(int id, CancellationToken cancellationToken)
        { 
            var exactUser = await Context.Users.FindAsync(new object?[] { id },cancellationToken);
            Context.Users.Remove(exactUser);
            await Context.SaveChangesAsync(cancellationToken);
        }
    }
}
