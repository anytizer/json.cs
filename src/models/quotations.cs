using configs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class quotations
    {
        public string quote()
        {
            string url = (new endpoints()).qotd;

            web w = new web();
            string quotation = w.get(url);

            return quotation;
        }
    }
}
