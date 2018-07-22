using CodeForGood;
using CodeForGood.Components;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codeforgood.Pages
{
	public class WeekendForGoodModel : PageModel
	{
		public DateRange DateRange { get; set; }
		public LocationAddress LocationAddress { get; set; }

		public void OnGet()
		{
			DateRange = WeekendForGoodServices.WhenIsWeekendForGood();
			LocationAddress = WeekendForGoodServices.WhereIsWeekendForGood();
		}
	}
}