using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Model
{
    public class LoginModel
    {
        public string user { get; set; }
        public string senha { get; }
        public IEnumerable<LoginModel> list_login { get; set; }
    }
}
