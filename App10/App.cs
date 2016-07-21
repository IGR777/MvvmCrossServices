using App10.Services;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace App10
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            //CreatableTypes()
            //    .EndingWith("Service")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();


            ServiceLocator.Instance.Register<ICalcService, CalcService>();
            ServiceLocator.Instance.Register<ILogService, LogService>();
            RegisterAppStart<ViewModels.CalcViewModel>();

        }
    }
}
