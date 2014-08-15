using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Button_Navigation_01
{
	partial class MagentaViewController : UIViewController
	{
		public MagentaViewController (IntPtr handle) : base (handle)
		{
		}

		[Action ("MagentaViewController:")]
		public void VoltarMagentaViewController (UIStoryboardSegue segue)
		{
			Console.WriteLine ("Magenta!");
		}

	}
}
