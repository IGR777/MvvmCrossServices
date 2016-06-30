using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace App10.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class CalcView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
