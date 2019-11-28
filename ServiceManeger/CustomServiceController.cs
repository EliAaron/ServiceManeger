using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Management;
using System.Diagnostics;

namespace ServiceManeger
{
    /// <summary>
    /// Extends ServiceController.
    /// Adds StartupMode and Description properties
    /// </summary>
    [System.ComponentModel.DesignerCategory("")] //Disable designer
    public class CustomServiceController : ServiceController
    {
        // Static ManagementObject to retrieve service data.
        // The static is for better performance
        private static ManagementObject ManagementObj = new ManagementObject();

        /// <summary>
        /// StartupMode of service (Disabled|Manual|Auto).
        /// </summary>
        public string StartupMode { get; private set; }

        /// <summary>
        /// Description text of service.
        /// </summary>
        public string Description { get; private set; }

        // Inherited constructors
        public CustomServiceController() : base() { SetExtentedProperties(); }
        public CustomServiceController(string name) : base(name) { SetExtentedProperties(); }
        public CustomServiceController(string name, string machineName)
            : base(name, machineName) { SetExtentedProperties(); }

        // Add constructor to convert ServiceController to ServiceControllerPlus
        public CustomServiceController(ServiceController sevice)
        {
            this.ServiceName = sevice.ServiceName;
            this.MachineName = sevice.MachineName;
            SetExtentedProperties();
        }

        // Set StartupMode and Description properties.
        private void SetExtentedProperties()
        {
            if (this.ServiceName != null)
            {
                ManagementObj.Path.Path = "Win32_Service.Name='" + ServiceName + "'";

                StartupMode = (string)ManagementObj.GetPropertyValue("StartMode");

                Description = (string)ManagementObj.GetPropertyValue("Description");
            }
            else
            {
                StartupMode = string.Empty;
                Description = string.Empty;
            }
        }

        /// <summary>
        /// Get all services.
        /// </summary>
        /// <returns></returns>
        public static new CustomServiceController[] GetServices()
        {
            ServiceController[] baseServiceList = ServiceController.GetServices();
            CustomServiceController[] serviceList = new CustomServiceController[baseServiceList.Length];

            for (int i = 0; i < baseServiceList.Length; i++)
            {
                serviceList[i] = new CustomServiceController(baseServiceList[i]);
            }

            return serviceList;
        }


    }
}
