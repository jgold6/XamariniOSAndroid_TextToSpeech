using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Speech.Tts;
using System.Collections.Generic;

namespace TextToSpeech.Droid
{
    [Activity(Label = "TextToSpeech.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
		Android.Speech.Tts.TextToSpeech speaker; 
		string toSpeak;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            
			button.Click += (object sender, EventArgs e) => 
			{
				Button btn = (Button)sender;
				toSpeak = btn.Text;
				if (speaker == null) {
					speaker = new Android.Speech.Tts.TextToSpeech (this, this);
				} else {
					var p = new Dictionary<string,string> ();
					speaker.Speak (toSpeak, QueueMode.Flush, p);
					System.Diagnostics.Debug.WriteLine ("spoke " + toSpeak);
				}
            };
        }

		#region IOnInitListener implementation
		public void OnInit (OperationResult status)
		{
			if (status.Equals (OperationResult.Success)) {
				System.Diagnostics.Debug.WriteLine ("speaker init");
				var p = new Dictionary<string,string> ();
				speaker.Speak (toSpeak, QueueMode.Flush, p);
			} else {
				System.Diagnostics.Debug.WriteLine ("was quiet");
			}
		}
		#endregion
    }


}


