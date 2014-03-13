using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Saga
    {
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public byte[] Data { get; set; }
        public string Langd { get; set; }
        public int Pris { get; set; }
        public DateTime Upplagd { get; set; }
        public string Redaktor { get; set; }
        public int Nedladdningar { get; set; }
    }
}
