// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Button_Navigation_01
{
	[Register ("MagentaViewController")]
	partial class MagentaViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnVerde { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnVoltarAmarelo { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnVerde != null) {
				btnVerde.Dispose ();
				btnVerde = null;
			}
			if (btnVoltarAmarelo != null) {
				btnVoltarAmarelo.Dispose ();
				btnVoltarAmarelo = null;
			}
		}
	}
}
