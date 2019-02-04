using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace XamarinFormsFonts
{
	public class CodeContentPage : ContentPage
	{
        public string ParseHexValueToString(string HexValue)
        {
            return Convert.ToChar((char)short.Parse(HexValue, NumberStyles.AllowHexSpecifier)) + " ";
        }
        public CodeContentPage ()
		{
            OnPlatform<string> FontDictionary = Application.Current.Resources["FontAwesomeRegular"] as OnPlatform<string>;

            string CharValueAsString = ParseHexValueToString("f58b");
            string Font = FontDictionary;
            Debug.WriteLine(string.Format("{0}:{1}", "Font", Font));
            Content = new StackLayout
            {
                Children = {
                    new Label { Text=ParseHexValueToString("f58b"),
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        FontSize=36,
                        FontFamily=Font
                      }
				}
			};
		}
	}
}