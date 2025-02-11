using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public record QOnly
    {
        public int id { get; set; }
        public int question { get; set; }
    }
}
