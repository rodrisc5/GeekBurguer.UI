using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contracts.Commands.Output
{
    public class OutputOrderCommand
    {
        public int OrderId { get; set; }
        public string StoreName { get; set; }
        public string Total { get; set; }
    }
}
