using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q127WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(beginWord, 1));
            while (queue.Count > 0) {
                Node node = queue.Dequeue();
                if (endWord == node.word)
                    return node.distance;
                for (int i = 0; i < wordList.Count; i++) {
                    int differences = 0;
                    for (int j = 0; j < endWord.Length; j++){
                        if (node.word[j] != wordList[i][j])
                            differences++;
                    }
                    if (differences == 1) { 
                        queue.Enqueue(new Node(wordList[i], node.distance+1));
                        wordList.RemoveAt(i);
                        i--;
                    }
                }
            }
            return 0;
        }
    }
    public record Node(string word, int distance);
}
