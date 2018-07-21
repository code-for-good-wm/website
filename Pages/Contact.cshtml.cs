using System.Threading.Tasks;

using CodeForGood.Components;
using CodeForGood.Config;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace CodeForGood.Pages
{
	public class ContactModel : PageModel
	{
		public TeamEmail Type { get; set; }

		public string Message { get; set; }

		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPost(ContactModel form)
		{
			var emailSvc = HttpContext.RequestServices.GetService<IEmailDispatcherService>();

			var msg = new EmailMessage
			{
				To = form.Type.ToMailAddress(),
				Subject = "Website Contact Form",
				IsBodyHtml = false,
				Body = form.Message
			};

			await emailSvc.SendEmail(msg);

			return RedirectToPage("Thank-You");
		}
	}
}