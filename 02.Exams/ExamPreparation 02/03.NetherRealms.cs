using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03NeatherRealm
{
    class Program
    {
        static void Main()
        {
            var demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = @"-?\d+\.?\d*";
            var demonHealts = new SortedDictionary<string, int>();
            var demonDamages = new SortedDictionary<string, double>();
            Regex regex = new Regex(pattern);
            foreach (var demon in demons)
            {
                var health = demon.Where(s => !char.IsDigit(s) && s != '+' && s!= '-' && s != '*' && s != '/' && s != '.').Sum(s =>s);
                demonHealts[demon] = health;

                var damage = 0.0;
                MatchCollection matches = regex.Matches(demon);
                foreach (Match match in matches)
                {
                    var value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }
                demonDamages[demon] = damage;
            }

            foreach (var demon in demonDamages)
            {
                var demonName = demon.Key;
                var demonHealth = demonHealts[demonName];
                var demonDamage = demon.Value;
                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:f2} damage");
            }
        }
    }
}
