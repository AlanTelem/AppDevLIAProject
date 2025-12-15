using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevProj
{
    public class UserData
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = ""; 
        public List<string> Friends { get; set; } = new List<string>();
    }
}
