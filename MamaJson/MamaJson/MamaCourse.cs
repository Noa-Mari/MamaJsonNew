using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamaJson
{
    public class MamaCourse
    {
        public string Name { get; set; }
        public int Cycle { get; set; }
        public List<string> Bases { get; set; }
        public int StudentsCount { get; set; }
    }
}