using configs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class members
    {
        public List<idv> all()
        {
            string url = (new endpoints()).members;

            web w = new web();
            string membersJSON = w.get(url);

            List<idv> list = JsonConvert.DeserializeObject<List<idv>>(membersJSON);

            return list;
        }
    }
}
