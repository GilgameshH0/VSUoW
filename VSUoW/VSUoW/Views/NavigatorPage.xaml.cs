using System;

using System.Collections.Generic;
using System.Reflection;


using Xamarin.Forms;

using Xamarin.Forms.Xaml;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using BitmapExtensions;
using TouchTracking;
using System.IO;

namespace VSUoW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigatorPage : ContentPage
    {
        TouchManipulationBitmap bitmap;
        List<long> touchIds = new List<long>();
        MatrixDisplay matrixDisplay = new MatrixDisplay();
        public NavigatorPage()
        {
            InitializeComponent();
            string resourceID = "VSUoW.bmpmap.bmp";
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream(resourceID))
            {

                SKBitmap bitmap = SKBitmap.Decode(stream);
                this.bitmap = new TouchManipulationBitmap(bitmap);
                this.bitmap.TouchManager.Mode = TouchManipulationMode.ScaleRotate;
                using (SKCanvas canvas = new SKCanvas(bitmap))
                {
                    using (SKPaint fairway = new SKPaint())
                    {
                        fairway.Style = SKPaintStyle.Stroke;
                        fairway.Color = SKColors.Red;
                        fairway.StrokeWidth = 7;
                        

                        using (SKPath path = new SKPath())
                        {
                            path.MoveTo(320, 390);                          
                            path.LineTo(320,485);
                            // path.MoveTo(320, 390);
                            
                            canvas.DrawPath(path, fairway);
                        }
                    }
                }
            }
            
        }

        void OnTouchModePickerSelectedIndexChanged(object sender, EventArgs args)
        {
            if (bitmap != null)
            {
                Picker picker = (Picker)sender;
                bitmap.TouchManager.Mode = (TouchManipulationMode)picker.SelectedItem;
            }
        }
        void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            // Convert Xamarin.Forms point to pixels
            Point pt = args.Location;
            SKPoint point =
                new SKPoint((float)(canvasView.CanvasSize.Width * pt.X / canvasView.Width),
                            (float)(canvasView.CanvasSize.Height * pt.Y / canvasView.Height));

            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    if (bitmap.HitTest(point))
                    {
                        touchIds.Add(args.Id);
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point);
                        break;
                    }
                    break;

                case TouchActionType.Moved:
                    if (touchIds.Contains(args.Id))
                    {
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point);
                        canvasView.InvalidateSurface();
                    }
                    break;

                case TouchActionType.Released:
                case TouchActionType.Cancelled:
                    if (touchIds.Contains(args.Id))
                    {
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point);
                        touchIds.Remove(args.Id);
                        canvasView.InvalidateSurface();
                    }
                    break;
            }
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {

            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            // Display the bitmap
         //   BitmapStretch stretch 

            bitmap.Paint(canvas);
           

            // Display the matrix in the lower-right corner
            //SKSize matrixSize = matrixDisplay.Measure(bitmap.Matrix);

            //matrixDisplay.Paint(canvas, bitmap.Matrix,
            //    new SKPoint(info.Width - matrixSize.Width,
            //                info.Height - matrixSize.Height));
        }
    }
}