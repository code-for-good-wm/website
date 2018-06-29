using CodeForGood.Components;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeForGood.Pages
{
	public class IndexModel : PageModel
	{
		public DateRange WeekendForGoodDateRange { get; set; }

		public void OnGet()
		{
			WeekendForGoodDateRange = WeekendForGoodServices.WhenIsWeekendForGood();
		}
	}
}