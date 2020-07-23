using System;
using System.Collections.Generic;

namespace CourseLib
{
	public class WebColor
	{
		public string ColorName { get; set; }
		public string HexValue { get; set; }
		public int RedValue { get; set; }
		public Single RedPercent
		{
			get
			{
				return RedValue / 255.0F;
			}
		}

		public int GreenValue { get; set; }
		public Single GreenPercent
		{
			get
			{
				return GreenValue / 255.0F;
			}
		}
		public int BlueValue { get; set; }
		public Single BluePercent
		{

			get
			{
				return BlueValue / 255F;
			}
		}
		public HSL HSL { get; set; }
		public ColorFamily ColorFamily { get; set; }

	}
	public  struct HSL {
		
		public int Hue;
		public int Saturation;
		public int Lightness;
	}

	public enum ColorFamily
	{
		Red,
		Yellow,
		Orange,
		Pink,
		Green,
		Blue,
		Cyan,
		Purple,
		Pale,
		Brown,
		Gray,

	}
	
}
