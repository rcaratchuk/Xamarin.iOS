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
	[Register ("VerdeViewController")]
	partial class VerdeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnVoltarAmarelo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnVoltarMagenta { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnVoltarAmarelo != null) {
				btnVoltarAmarelo.Dispose ();
				btnVoltarAmarelo = null;
			}
			if (btnVoltarMagenta != null) {
				btnVoltarMagenta.Dispose ();
				btnVoltarMagenta = null;
			}
		}
	}
}
