using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs
{
    public class endpoints
    {
        /**
         * Globally available
         */
        private string endpoint_server = "http://localhost/angular/libraries/json.cs/src";

        private string url(string member)
        {
            switch (member.ToLower())
            {
                case "members":
                case "time":
                case "qotd":
                    member = member.ToLower();
                    break;
                default:
                    member = "ping";
                    break;
            }

            string url = this.endpoint_server + "/api/" + member + ".php";
            return url;
        }

        /**
         * Context specific
         */
        public string members
        {
            get { return url("members"); }
            private set { }
        }

        public string time
        {
            get { return this.url("time"); }
            private set { }
        }

        public string qotd
        {
            get { return this.url("qotd"); }
            private set { }
        }
    }
}
