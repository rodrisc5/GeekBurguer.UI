using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contracts.Commands
{
    public class BaseCommand
    {
        public bool Processing { get; set; }
        public int UserId { get; set; }
    }
}
