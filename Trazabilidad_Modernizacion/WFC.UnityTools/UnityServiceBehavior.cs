﻿using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Unity;

namespace WCF.UnityTools
{
    public class UnityServiceBehavior : IServiceBehavior

    {

        public UnityInstanceProvider InstanceProvider

        { get; set; }

 
        public UnityServiceBehavior()
        {
            InstanceProvider = new UnityInstanceProvider();
        }

        public UnityServiceBehavior(UnityContainer unity)
        {
            InstanceProvider = new UnityInstanceProvider();
            InstanceProvider.Container = unity;
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {

            foreach (ChannelDispatcherBase cdb in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher cd = cdb as ChannelDispatcher;
                if (cd != null)
                {
                    foreach (EndpointDispatcher ed in cd.Endpoints)
                    {
                    
                        InstanceProvider.ServiceType = serviceDescription.ServiceType;
                        ed.DispatchRuntime.InstanceProvider = InstanceProvider;
                    }
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase) { }

        public void AddBindingParameters(

            ServiceDescription serviceDescription,

            ServiceHostBase serviceHostBase,

            Collection<ServiceEndpoint> endpoints,

            BindingParameterCollection bindingParameters)

        {

        }
 
    }
}
