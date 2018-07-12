using CodeForGood;
using CodeForGood.Components;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeforgood.Pages
{
	public class WeekendForGoodModel : PageModel
	{
		public DateRange WeekendForGoodDateRange { get; set; }

		public void OnGet()
		{
			WeekendForGoodDateRange = WeekendForGoodServices.WhenIsWeekendForGood();
		}
	}
}