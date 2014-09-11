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

namespace TextToSpeech.iOS
{
	[Register ("TextToSpeech_iOSViewController")]
	partial class TextToSpeech_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSpeak { get; set; }

		[Action ("btnSpeak_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSpeak_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSpeak != null) {
				btnSpeak.Dispose ();
				btnSpeak = null;
			}
		}
	}
}
