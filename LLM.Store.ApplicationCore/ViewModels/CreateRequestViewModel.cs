using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLM.Store.ApplicationCore.ViewModels
{
    public class CreateRequestViewModel
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public char Gender { get; set; }
        public string MobileNumber { get; set; }

    }
}
