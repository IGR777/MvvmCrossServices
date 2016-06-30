// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App10.iOS.Views
{
    [Register ("FirstView")]
    partial class CalcView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalcButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextArg1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextArg2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TextResult { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CalcButton != null) {
                CalcButton.Dispose ();
                CalcButton = null;
            }

            if (TextArg1 != null) {
                TextArg1.Dispose ();
                TextArg1 = null;
            }

            if (TextArg2 != null) {
                TextArg2.Dispose ();
                TextArg2 = null;
            }

            if (TextResult != null) {
                TextResult.Dispose ();
                TextResult = null;
            }
        }
    }
}