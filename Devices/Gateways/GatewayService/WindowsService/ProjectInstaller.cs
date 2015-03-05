﻿namespace Microsoft.ConnectTheDots.GatewayService
{
    using System.ComponentModel;
    using System.Configuration.Install;
    using System.ServiceProcess;
    using Microsoft.ConnectTheDots.Gateway;

    //--//

    [RunInstaller( true )]
    public class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller( )
        {
            process = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem
            };
            service = new ServiceInstaller
            {
                ServiceName = Constants.WindowsServiceName
            };
            Installers.Add( process );
            Installers.Add( service );
        }
    }
}