using System;
using System.Collections.Generic;

namespace Tries
{
    class TNode 
    {
        public char Letter;
        public List<TNode> Nexts;
        public TNode(char letter)
        {
            Letter = letter;
            Nexts = new List<TNode>();
        }
        public Boolean Has_char(char letter)
       {
           foreach (TNode innner_node in this.Nexts)
           {
               if (innner_node.Letter == letter)
                    return true;
           }
           return false;
       }
    }
    class TList
    {
       public TNode Head;
       public TList(TNode node)
       {
           Head = node;
       }
       public void Add(string word)
       {
           Console.WriteLine("adding word " + word);
           char[] word_array;
           word_array = word.ToCharArray();
           TNode runner = Head;
           foreach (char letter in word_array)
           {
            Console.WriteLine("*****For letter: " + letter);
               if (!runner.Has_char(letter))
               {
                Console.WriteLine("************Is not in Nexts");
                   TNode temp = new TNode(letter);
                   runner.Nexts.Add(temp);
                Console.WriteLine(">>>>>>Current runnner now has " + runner.Nexts[runner.Nexts.Count - 1].Letter);
                   runner = runner.Nexts[runner.Nexts.Count - 1];
               }
               else
               {
                   Console.WriteLine("?????????Going to else");
                   int target_index = 0;
                   foreach (TNode node in runner.Nexts)
                   {
                       if (node.Letter != letter)
                            target_index++;
                        else
                            runner = runner.Nexts[target_index]; 
                   }
               }
           }
       }
       public void Print()
       {
           TNode runner = Head;
            Console.WriteLine("---------------------------");
           while (runner.Nexts.Count > 0)
           {
               Console.WriteLine(runner.Letter);
               if (runner.Nexts.Count > 1)
                    runner = runner.Nexts[1];
                else
                     runner = runner.Nexts[0];
           }
            Console.WriteLine(runner.Letter);
             Console.WriteLine("---------------------------");
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TNode start_char = new TNode('@');
            TList start = new TList(start_char);
            start.Add("pidr");
            start.Print();
            start.Add("pidor");
             start.Print();
        }
    }
}
