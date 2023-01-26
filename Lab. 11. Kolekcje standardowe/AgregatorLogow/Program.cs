using System;
using System.Collections.Generic;
using System.Linq;

namespace AgregatorLogow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var logs = new Dictionary<string, Tuple<int, HashSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                string user = parts[1];
                int duration = int.Parse(parts[2]);
                string ip = parts[0];

                if (!logs.ContainsKey(user))
                {
                    logs[user] = Tuple.Create(duration, new HashSet<string> { ip });
                }
                else
                {
                    logs[user] = Tuple.Create(logs[user].Item1 + duration, logs[user].Item2);
                    logs[user].Item2.Add(ip);
                }
            }
            var users = logs.Keys.ToList(); 
            users.Sort();
            
            


            foreach (var user in users)
            {               
                Console.WriteLine("{0}: {1} [{2}]", user, logs[user].Item1, string.Join(", ", logs[user].Item2.OrderBy(x => x)));
            }
        }
    }
}


