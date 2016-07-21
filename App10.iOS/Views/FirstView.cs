using App10.Converters;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace App10.iOS.Views
{
    public partial class CalcView : MvxViewController
    {
        public CalcView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<CalcView, ViewModels.CalcViewModel>();
            set.Bind(TextArg1).To(vm => vm.Arg1).WithConversion(new FloatValueConverter(), null);
            set.Bind(TextArg2).To(vm => vm.Arg2).WithConversion(new FloatValueConverter(), null); ;
            set.Bind(TextResult).To(vm => vm.Result);
            set.Bind(CalcButton).To(vm => vm.CalculateCommand);
            set.Apply();
        }
    }
}
