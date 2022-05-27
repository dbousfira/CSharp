using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_vers_dictionnaire
{
    class Program
    {
        static readonly string[] strings = { "zero", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix" };

        static void Main(string[] args)
        {
            var dico = Enumerable.Range(0, 10).Select(test => new Test { UnString = strings[test], UnInt = test })
                .ToDictionary(test => test.UnInt, test => test.UnString);
            foreach (var kvp in dico)
            {
                Console.WriteLine(kvp);
            }
        }
    }


    class Test
    {
        public string UnString { get; set; }

        public int UnInt { get; set; }
    }
}
