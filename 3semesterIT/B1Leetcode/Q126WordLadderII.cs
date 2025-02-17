using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q126WordLadderII
    {
        public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, int> seen = new Dictionary<string, int>();
            IList<IList<string>> result = new List<IList<string>>();
            Queue<LadderNode> queue = new Queue<LadderNode>();
            queue.Enqueue(new LadderNode(beginWord, new List<string> { beginWord }));
            while (queue.Count > 0){
                LadderNode node = queue.Dequeue();
                if (endWord == node.word && (result.Count == 0 || node.path.Count == result[0].Count)) {
                    result.Add(node.path);
                }
                if (result.Count == 0)
                {
                    for (int i = 0; i < wordList.Count; i++)
                    {
                        int differences = 0;
                        for (int j = 0; j < endWord.Length; j++)
                        {
                            if (node.word[j] != wordList[i][j])
                            {
                                differences++;
                            }
                        }
                        if (differences == 1)
                        {
                            if (!seen.ContainsKey(wordList[i]) || node.path.Count < seen[wordList[i]]) {
                                List<string> newPath = new List<string>(node.path) { wordList[i] };
                                queue.Enqueue(new LadderNode(wordList[i], newPath));
                                seen[wordList[i]] = newPath.Count;
                            }
                        }
                    }
                }
            }
            return result;
        }
        public record LadderNode(string word, IList<string> path);
    }
}
