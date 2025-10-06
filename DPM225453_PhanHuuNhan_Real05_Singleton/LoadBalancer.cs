using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Real01_Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer instance;
        private List<string> servers = new List<string>();
        private Random random = new Random();

        // Lock synchronization object
        private static object locker = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Double-checked locking
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
