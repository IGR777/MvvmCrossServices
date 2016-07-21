using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App10.Services
{
    class ServiceLocator
    {
        Dictionary<Type, Lazy<object>> _registeredServices = new Dictionary<Type, Lazy<object>>();

        ServiceLocator()
        {
        }

        static Lazy<ServiceLocator> _instance = new Lazy<ServiceLocator>(()=> new ServiceLocator());

        public static ServiceLocator Instance{
            get
            {
                return _instance.Value;
            }
        }

        public void Register<TInterface, TImplementation>()
        {
            _registeredServices.Add(typeof(TInterface), new Lazy<object>(()=>Create(typeof(TImplementation))));
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));

        }

        public object Resolve(Type t)
        {
            Lazy<object> service = null;
            if (_registeredServices.TryGetValue(t, out service))
                return service.Value;

            throw new Exception("service not found");
        }

        object Create(Type t)
        {
            var ti = t.GetTypeInfo();

            var ctors = ti.DeclaredConstructors.Where(item => item.IsPublic).ToList();
            var ctor = ctors.FirstOrDefault(item=>item.GetParameters().Length ==0);
            if (ctor != null)
                Activator.CreateInstance(t);

            ctor = ctors[0];

            var prms = new List<object>();
            foreach (var prm in ctor.GetParameters())
            {
                prms.Add(Resolve(prm.ParameterType));
            }

           return  Activator.CreateInstance(t, prms.ToArray());

        }


            


    }
}
