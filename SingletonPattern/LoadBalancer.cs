using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    // Class cân bằng tải server 
    public sealed class LoadBalancer
    {
        // singleton implemented
        private static readonly LoadBalancer _instance = new();
        private readonly List<Server> _servers;
        private readonly Random _random = new ();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Name = "ServerV", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetInstance()
        {
            return _instance;
        }

        public Server NextServer()
        {
            int r = _random.Next(_servers.Count);
            return _servers[r];
        }
    }

    public class Server
    {
        public string Name { get; set; } = string.Empty;
        public string IP { get; set; } = string.Empty;
    }
}
