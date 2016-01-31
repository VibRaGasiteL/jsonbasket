using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using jsonbasket;
using Newtonsoft.Json;


namespace jsonbasket
{
    class Program
    {
        static void Main(string[] args)
        {
            string responsetext = new WebClient().DownloadString("http://api.lod-misis.ru/testassignment");
            //Player p = JsonConvert.DeserializeObject<Player>(responsetext);
            List<Player> p = JsonConvert.DeserializeObject<List<Player>>(responsetext);
            p.Sort(delegate (Player x, Player y)
             { return y.Score.CompareTo(x.Score); });
            Console.WriteLine(">>{0,19}<<", "Cleveland Cavaliers");
            Console.Write("Name: "); Console.SetCursorPosition(19, 1); Console.WriteLine("Score: ");
            foreach (Player k in p)
            {
                if (k.Team =="CLE")
                {
                    Console.WriteLine("{0,18}| {1,5}|", k.PlayerName,k.Score);
                }
            }
            Console.WriteLine();
            Console.WriteLine(">>{0,18}<<", "Los Angeles Lakers");
            Console.Write("Name: "); Console.SetCursorPosition(19, 9); Console.WriteLine("Score: ");
            foreach (Player g in p)
            {
                if (g.Team=="LAL")
                {
                    Console.WriteLine("{0,18}| {1,5}|", g.PlayerName, g.Score);
                }
            }
            
            


            Console.ReadKey();

        }


    }
}
