using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Button_Navigation_01
{
	partial class AmareloViewController : UIViewController
	{
		public AmareloViewController (IntPtr handle) : base (handle)
		{
		}

		[Action ("AmareloViewController:")]
		public void VoltarAmareloViewController (UIStoryboardSegue segue)
		{
			Console.WriteLine ("Amarelo!");
		}
	}
}
