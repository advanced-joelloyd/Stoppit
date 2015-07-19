using System;
using CoreGraphics;
using UIKit;

namespace Stoppit
{
	public class HomeViewController : UIViewController
	{
		private UIButton _button;

		private readonly nfloat _xPadding = 10f;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;

			_button = UIButton.FromType(UIButtonType.RoundedRect);
			_button.SetTitle("NO", UIControlState.Normal);
			_button.Frame = new CGRect(_xPadding, 100, View.Bounds.Width - (_xPadding * 2), 44);
			_button.BackgroundColor = UIColor.White;
			_button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;

			View.AddSubview(_button);
		}
	}
}