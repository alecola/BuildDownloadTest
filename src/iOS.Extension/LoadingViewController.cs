using System;
using Google.Analytics;
using UIKit;

namespace Bit.iOS.Extension
{
    public partial class LoadingViewController : UIViewController
    {
        public LoadingViewController(IntPtr handle) : base(handle)
        { }

        public override void ViewDidLoad()
        {
            // These are all null in the app extension.
            System.Diagnostics.Debug.WriteLine(
                "TESTLOG: ClientId is null: " + GaiConstants.ClientId == null);
            System.Diagnostics.Debug.WriteLine(
                "TESTLOG: AppId is null: " + GaiConstants.AppId == null);

            base.ViewDidLoad();
        }
    }
}