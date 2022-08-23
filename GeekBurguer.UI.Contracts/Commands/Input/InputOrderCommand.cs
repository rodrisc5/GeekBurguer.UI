using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contracts.Commands.Input
{
    public class InputOrderCommand
    {
        public int OrderId { get; set; }
        public string StoreName { get; set; }
        public List<InputProductCommand> products { get; set; }
        public List<int> ProductionIds { get; set; }

    }
}
