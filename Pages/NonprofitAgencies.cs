using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeForGood.Pages
{
	public class NonprofitAgenciesModel : PageModel
	{
		public string Message { get; set; }

		public void OnGet()
		{
			Message = "Your non-profit agencies page.";
		}
	}
}