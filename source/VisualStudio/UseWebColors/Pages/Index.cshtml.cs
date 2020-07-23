using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CourseLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UseWebColors.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public IndexModel()
		{
			this.WebColors = CourseLib.ColorSource.GetColors();
			
		}

		public void OnPost()
		{ 
		 WebColors = CourseLib.ColorSource.GetColors().Where(x=>x.ColorFamily == CurrentColorFamily).ToList();
		}
		public void OnGet()
		{
			
			//var q = from color in colors
			//				where color.ColorFamily == CourseLib.ColorFamily.Blue
			//				|| color.ColorFamily == CourseLib.ColorFamily.Yellow
			//				select color;

		}
		public List<WebColor>	WebColors { get; set; }
		public ColorFamily ColorFamilies { get; set; }
		[BindProperty]
		public ColorFamily CurrentColorFamily { get; set; }

	}
}
