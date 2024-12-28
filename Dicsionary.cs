using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatoAlphabets
{
    public class Dicsionary
    {
        public void ChangeToNato()
        {
            Dictionary<char, string> natoAlphabets = new Dictionary<char, string>()
    {

         {'A', "Alpha"}, {'B', "Bravo"}, {'C', "Charlie"}, {'D', "Delta"}, {'E', "Echo"},
         {'F', "Foxtrot"}, {'G', "Golf"}, {'H', "Hotel"}, {'I', "India"}, {'J', "Juliett"},
         {'K', "Kilo"}, {'L', "Lima"}, {'M', "Mike"}, {'N', "November"}, {'O', "Oscar"},
         {'P', "Papa"}, {'Q', "Quebec"}, {'R', "Romeo"}, {'S', "Sierra"}, {'T', "Tango"},
         {'U', "Uniform"}, {'V', "Victor"}, {'W', "Whiskey"}, {'X', "X-ray"}, {'Y', "Yankee"},
         {'Z', "Zulu"},
    };
            int count = 0;
            foreach (var natoAlphabet in natoAlphabets)
            {
                count++;
                Console.WriteLine($" {count}. {natoAlphabet.Key} for {natoAlphabet.Value} ");
            }
        }

    }
}
