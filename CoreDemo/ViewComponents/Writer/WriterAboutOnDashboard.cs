using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
		WriterManager writermanager = new WriterManager(new EfWriterRepository());

		Context c = new Context();

		public IViewComponentResult Invoke()
		{
			//var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var username = User.Identity.Name;
			ViewBag.v = username;
			var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
			var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			var values = writermanager.GetWriterByID(writerID);
			return View(values);
		}
	}
}
