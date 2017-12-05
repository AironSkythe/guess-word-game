using System;
using System.Collections.Generic;
using System.IO;
namespace guess_word_game
{
    class Session
    {
        public List<Container> Tests;
        Container Current;
        List<int> usedQuests;
        public string PlayerName;
        public int Score
        {
            get;
            private set;
        }
  
        public Session()
        {
            usedQuests = new List<int>();
            Tests = new List<Container>();
            var fs = new StreamReader(@"C:\Users\Skythe\Desktop\решта\Візуал проекти\вгадай слово\слова\secret.txt");
            while (!fs.EndOfStream)
            {
                Tests.Add(   new Container ( fs.ReadLine().Split('-') )   );
            }
        }

        public Container GetQuest()
        {
            Random rand = new Random();
            int index;
            do
            {
                index = rand.Next(0, Tests.Count);
            }
            while (usedQuests.Contains(index));

            usedQuests.Add(index);
            Current = Tests[index];
            return Tests[index];
        }
        public bool IsWright(Container s)
        {
            if (s.Answer == Current.Answer)
                return true;
            else
                return false;

        }

    }
}
