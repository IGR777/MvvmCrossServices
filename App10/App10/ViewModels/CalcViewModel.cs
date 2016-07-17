using MvvmCross.Core.ViewModels;

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
                    if (Arg1.HasValue && Arg2.HasValue)
                        Result = (Arg1.Value + Arg2.Value).ToString();
                    else
                        Result = "";
                });
            }
        } 
    }
}
