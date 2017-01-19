using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadder
{

    class WordNode
    {
        public string Word { get; set; }
        public int Steps { get; set; }

        public WordNode(string word, int num)
        {
            Word = word;
            Steps = num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var start = "hit";
            var end = "cog";

            HashSet<string> dic = new HashSet<string>();
            dic.Add("hot");
            dic.Add("dot");
            dic.Add("dog");
            dic.Add("lot");
            dic.Add("log");

            var d = FindLadderLength(start, end, dic);
        }


        public static int FindLadderLength(string start, string end, HashSet<string> dic)
        {
            List<WordNode> queue = new List<WordNode>();

            queue.Add(new WordNode(start, 1));

            dic.Add(end);

            while (queue.Count != 0)
            {
                WordNode top = queue[queue.Count - 1];
                string word = top.Word;

                if (word.Equals(end))
                {
                    return top.Steps;
                }

                var arr = word.ToCharArray();

                for (var i = 0; i < arr.Length; i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        char temp = arr[i];

                        if (arr[i] != c)
                        {
                            arr[i] = c;
                        }

                        string newWord = new string(arr);
                        if (dic.Contains(newWord))
                        {
                            queue.Add(new WordNode(newWord, top.Steps+1));
                            dic.Remove(newWord);
                        }

                        arr[i] = temp;
                    }
                }
            }

            return 0;

        }
    }
}
