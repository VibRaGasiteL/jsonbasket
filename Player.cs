using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace jsonbasket
{
    
    public class Player
    {
        public string PlayerName { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }

    }
}
