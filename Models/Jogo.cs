using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_mvc.Models
{
    public class Jogo
    {
        public Time TimeA { get; set; }
        public Time TimeB { get; set; }
        public int TimeAPonto { get; set; }
        public int TimeBPonto { get; set; }
    }
}