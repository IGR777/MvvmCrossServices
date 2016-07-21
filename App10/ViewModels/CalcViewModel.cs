using App10.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace App10.ViewModels
{
    public class CalcViewModel 
        : MvxViewModel
    {
        private float? _arg1;
        public float? Arg1
        { 
            get { return _arg1; }
            set { SetProperty (ref _arg1, value); }
        }


        private float? _arg2;
        public float? Arg2
        {
            get { return _arg2; }
            set { SetProperty(ref _arg2, value); }
        }


        private string _result;
        public string Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public IMvxCommand CalculateCommand
        {
            get
            {
                return new MvxCommand(()=>
                {

                    var service = ServiceLocator.Instance.Resolve<ICalcService>();
                    var result = service.Calculate(Arg1, Arg2);
                    if (result == null)
                        Result = "";
                    else
                        Result = result.ToString();
                });
            }
        } 
    }
}
