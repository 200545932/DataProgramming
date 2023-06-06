using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProgramming
{
    internal class StringLegth
    {
        public void QuestionTwo() {

            var len_of_word = "Supercalifragilisticexpialidocious";
            Console.WriteLine(len_of_word.Length);

            string subStr = "ice";
            bool contains = len_of_word.Contains(subStr);
            Console.WriteLine(contains);

            string[] strings = { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };
            string longest_string = strings.Max();
            Console.WriteLine("The longest string is: " + longest_string);

            Console.WriteLine();

            Dictionary<string, string> composers = new Dictionary<string, string>()
{
                 {"Berlioz", "Hector Berlioz"},
                 {"Borodin", "Alexander Borodin"},
                 {"Brian", "Havergal Brian"},
                 {"Bartok", "Bela Bartok"},
                 {"Bellini", "Vincenzo Bellini"},
                 {"Buxtehude", "Dietrich Buxtehude"},
                 {"Bernstein", "Leonard Bernstein"}
};

            var sortedComposers = composers.OrderBy(x => x.Key);
            var firstComposer = sortedComposers.First();
            var lastComposer = sortedComposers.Last();

            Console.WriteLine($"First composer: {firstComposer.Key}");
            Console.WriteLine($"Last composer: {lastComposer.Key}");



        }
    }
}
