using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public record QOnly
    {
        public int id { get; set; } = -1;   
        public string question { get; set; } = string.Empty;
    }
}
