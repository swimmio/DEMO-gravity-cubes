using System;
using System.Collections.Generic;

namespace game.service
{
    public class ServiceLocator
    {
        private IDictionary<object, IService> services;

        public ServiceLocator()
        {
            services = new Dictionary<object, IService>();
        }

        public T GetService<T>()
        {
            try
            {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }

        public void RegisterService<T>(T service) where T: IService
        {
            services[typeof(T)] = service;
        }
    }
}