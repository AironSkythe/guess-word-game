using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_word_game
{
   public class Container
    {
        public string Quest
        {
            get;
            private set;
        }
        public string Answer
        {
            get;
            private set;
        }
        public Container(string qe, string ans)
        {
            Quest = qe;
            Answer = ans;
        }
        public Container(string[] args)
        {
            Quest = args[0];
            Answer = args[1];
        }
    }
}
