using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Button_Navigation_01
{
	partial class VerdeViewController : UIViewController
	{
		public VerdeViewController (IntPtr handle) : base (handle)
		{
		}
		[Action ("VerdeViewController:")]
		public void VoltarVerdeViewController (UIStoryboardSegue segue)
		{
			Console.WriteLine ("Magenta!");
		}
	}
}
