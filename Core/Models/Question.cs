using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public record Question
    {
        public int id { get; set; } = -1;
        public string question { get; set; } = string.Empty;
        public List<Answer> answer { get; set; } = new List<Answer>();
    }
}
