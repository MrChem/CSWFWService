using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Consul;

namespace CSWFWUserServiice
{
    public static  class ConsoulHelper
    {
        public static void ConsoulRegttist(this  IConfiguration configuration) {
            Consul.ConsulClient  client= new ConsulClient(c=> {
                c.Address = new Uri("http://localhost:8500");
                c.Datacenter = "dc1";
            });

            string ip = configuration["ip"];
            int port = int.Parse(configuration["port"]);
            //注册consoul
            client.Agent.ServiceRegister(new AgentServiceRegistration()
            {
                ID = ip + "User-" + Guid.NewGuid(),
                Name = "CSUser",
                Address = ip,
                Port=port,
                //心跳检查
                Check=new AgentServiceCheck { 
                    DeregisterCriticalServiceAfter=TimeSpan.FromSeconds(5),
                    //
                    HTTP=$"http://{ip}:{port}/weatherforecast",
                    //
                    Interval=TimeSpan.FromSeconds(10),
                    //
                    Timeout=TimeSpan.FromSeconds(60)
                }

            });

           

        }
    }
}
