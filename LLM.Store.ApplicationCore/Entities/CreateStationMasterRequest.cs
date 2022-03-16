using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLM.Store.ApplicationCore.Entities
{
    public class CreateStationMasterRequest
    {
        public string station_code { get; set; }
        public string station_name { get; set; }
        public int account_id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
