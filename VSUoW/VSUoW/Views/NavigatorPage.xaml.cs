using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xamarin.Forms;
using SkiaSharp.Views;
using SkiaSharp.Views.Forms;

using Xamarin.Forms.Xaml;

namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigatorPage : ContentPage
	{
		public NavigatorPage ()
		{
			InitializeComponent ();
		}
        
        public void DrawLineInt(Bitmap bmp)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            int x1 = 100;
            int y1 = 100;
            int x2 = 500;
            int y2 = 100;
            // Draw line to screen.
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
        }

    }
    }
}