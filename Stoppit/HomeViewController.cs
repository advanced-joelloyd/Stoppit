using System;
using CoreGraphics;
using Foundation;
using RestSharp;
using UIKit;

namespace Stoppit
{
	public class HomeViewController : UIViewController
	{
		private UIButton _button;

		private readonly nfloat _xPadding = 10f;
		private UILabel _label;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;

			nfloat width = View.Bounds.Width - (_xPadding*2);

			_label = new UILabel
			{
				Text = "Do as you're told",
				Frame = new CGRect(_xPadding, 100, width, 31),
				TextAlignment = UITextAlignment.Center,
				AutoresizingMask = UIViewAutoresizing.FlexibleWidth
			};

			_button = UIButton.FromType(UIButtonType.RoundedRect);
			_button.SetTitle("NO", UIControlState.Normal);
			_button.Frame = new CGRect(_xPadding, 150, width, 44);
			_button.BackgroundColor = UIColor.White;
			_button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			_button.TouchUpInside += (s, e) => { GetBossier(); };

			View.AddSubview(_label);
			View.AddSubview(_button);
		}

		private void GetBossier()
		{
			var client = new RestClient("http://doasyouretold.apphb.com/");
			var request = new RestRequest("", Method.GET)
			{
				RequestFormat = DataFormat.Json
			};

			var response = client.Execute(request);
			_label.Text = response.Content;
		}
	}
}