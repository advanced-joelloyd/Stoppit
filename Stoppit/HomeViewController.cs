using System;
using UIKit;

namespace Stoppit
{
	public class HomeViewController : UIViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Title = "Do As You're Told";
			View.BackgroundColor = UIColor.LightGray;
		}
	}
}