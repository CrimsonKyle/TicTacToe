using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TicTacToe.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            UIApplication.SharedApplication.StatusBarHidden = true;

            Xamarin.Calabash.Start();

            return base.FinishedLaunching(app, options);
        }
    }
}
