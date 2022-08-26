using AdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using NuGet.Protocol.Plugins;
using System;
using System.Threading;

namespace AdminPanel.Web.Controllers
{
    public class UsersController : BaseController
    {
        public IActionResult Index()
        {
            var model = Context.Users.OrderByDescending(t => t.DateCreated).ToArray();
            return View(model);
        }

        public IActionResult Edit(int? id)
        {
            var user = id !=null ? Context.Users.Find(id) : new User();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                if (user.Id == 0)
                    user.DateCreated = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                user.DateUpdated = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                Context.Users.Update(user);
                await Context.SaveChangesAsync(cancellationToken);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id, CancellationToken cancellationToken)
        { 
            var exactUser = await Context.Users.FindAsync(new object[] {id},cancellationToken);
            Context.Users.Remove(exactUser);
            await Context.SaveChangesAsync(cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
