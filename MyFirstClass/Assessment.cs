using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass {

    internal class Assessment {

        public int Points { get; set; } = 0;
        public string Topic { get; set; } = string.Empty;
        public DateTime Taken { get; set; } = DateTime.MinValue;

        public string Print() {
            return $"Assessment: {Points} points on {Topic} taken on {Taken}";
        }
    }
}
