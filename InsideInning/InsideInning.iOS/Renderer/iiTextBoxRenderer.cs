using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using InsideInning;
using InsideInning.iOS.Renderer;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(iiTextBox), typeof(iiTextBoxRenderer))]

namespace InsideInning.iOS.Renderer
{
    public class iiTextBoxRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.BorderColor = UIColor.White.CGColor;
                Control.Layer.BorderWidth = 1f;
                Control.BorderStyle = UITextBorderStyle.Line;
                Control.Layer.CornerRadius = 0;
                Control.ClipsToBounds = true;
                switch (e.NewElement.ClassId)
                {
                    case "1":
                        Control.LeftView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("name"));
                        break;
                    case "3":
                        Control.LeftView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("email"));
                        break;
                    case "4":
                        Control.LeftView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("password"));
                        break;
                    case "5":
                        Control.LeftView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("Usrename"));
                        break;
                    case "6":
                        Control.LeftView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("password"));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
       
