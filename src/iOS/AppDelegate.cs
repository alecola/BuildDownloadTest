using System;
using Foundation;
using Google.Analytics;
using UIKit;
using Xamarin.Forms;

namespace Bit.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            LoadApplication(new App.App());

            // These are not null in the main app.
            System.Diagnostics.Debug.WriteLine(
                "TESTLOG: ClientId is null: " + GaiConstants.ClientId == null);
            System.Diagnostics.Debug.WriteLine(
                "TESTLOG: AppId is null: " + GaiConstants.AppId == null);

            return base.FinishedLaunching(app, options);
        }
    }
}
