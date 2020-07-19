<Query Kind="Statements" />

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
	public int Hue { get; set; }
	public int Saturation { get; set; }
	public int Lightness { get; set; }
	public ColorFamily ColorFamily { get; set; }

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
	White,
	Brown,
	Gray
}
public class ColorSource
{
	public static List<WebColor> GetColors()
	{
		var temp = new List<WebColor>();
		temp.Add(new WebColor
		{
			ColorName = "Darkred",
			HexValue = "8B0000",
			RedValue = 139,
			GreenValue = 0,
			BlueValue = 0,
			Hue = 0,
			Saturation = 100,
			Lightness = 27,
			ColorFamily = ColorFamily.Red
		});

		temp.Add(new WebColor
		{
			ColorName = "FireBrick",
			HexValue = "B22222",
			RedValue = 178,
			GreenValue = 34,
			BlueValue = 34,
			Hue = 0,
			Saturation = 68,
			Lightness = 42,
			ColorFamily = ColorFamily.Red
		});

		temp.Add(new WebColor
		{
			ColorName = "IndianRed",
			HexValue = "CD5C5C",
			RedValue = 205,
			GreenValue = 92,
			BlueValue = 92,
			Hue = 0,
			Saturation = 53,
			Lightness = 58,
			ColorFamily = ColorFamily.Red
		});

		//		temp.Add(new WebColor
		//{
		//	ColorName = "",
		//	HexValue = "",
		//	RedValue = ,
		//	GreenValue = ,
		//	BlueValue = ,
		//	Hue = ,
		//	Saturation = ,
		//	Lightness =,
		//	ColorFamily = ColorFamily.Red});

		return temp;
	}

}