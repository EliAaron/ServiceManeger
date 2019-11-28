using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Collections;
using System.Diagnostics;

namespace ServiceManeger
{
    /// <summary>
    /// A ServiceControllerPlus Dictionary collection.
    /// </summary>
    public class ServiceDictionary : IEnumerable
    {
        Dictionary<int, CustomServiceController> serviceDictionary;

        public ServiceDictionary()
        {
        }

        public int Count
        {
            get { return serviceDictionary.Count(); }
        }

        /// <summary>
        /// Load all service to collection.
        /// </summary>
        public void Load()
        {
            CustomServiceController[] ServiceControllers = CustomServiceController.GetServices();

            serviceDictionary = new Dictionary<int, CustomServiceController>();
            for (int i = 0; i < ServiceControllers.Length; i++)
			{
                serviceDictionary.Add(i, ServiceControllers[i]);
			}     
        }

        public IEnumerator GetEnumerator()
        {
            return serviceDictionary.GetEnumerator();
        }

        public CustomServiceController this[int Key]
        {
            get { return serviceDictionary[Key]; }
        }
    }
}
