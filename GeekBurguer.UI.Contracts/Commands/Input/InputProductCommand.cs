using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contracts.Commands.Input
{
    public class InputProductCommand
    {
        public int ProductId { get; set; }
        public string Price { get; set; }
    }
}
