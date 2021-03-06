using CodeForGood.Components;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeForGood.Pages
{
	public class ScheduleModel : PageModel
	{
		public DateRange DateRange { get; set; }

		public void OnGet()
		{
			DateRange = WeekendForGoodServices.WhenIsWeekendForGood();
		}
	}
}