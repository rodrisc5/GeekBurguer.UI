using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contracts.Commands.Input
{
    public class InputFoodRestrictionsCommand
    {
        public List<string> Restrictions { get; set; }
        public string Others { get; set; }
        public int UserId { get; set; }
        public int RequesterId { get; set; }

    }
}
