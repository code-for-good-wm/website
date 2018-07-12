using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeForGood.Pages
{
	public class AboutModel : PageModel
	{
		public string Message { get; set; }

		public void OnGet()
		{
			Message = "Your application description page.";
		}
	}
}