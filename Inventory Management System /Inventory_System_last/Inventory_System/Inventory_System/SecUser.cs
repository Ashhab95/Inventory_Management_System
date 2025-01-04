using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
  public  class SecUser
    {
        public string Name { get; set; }
        public string Phones { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
