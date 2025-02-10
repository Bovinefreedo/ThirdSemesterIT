using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
	public class Q3160DistinctBalls
	{
		public int[] QueryResults(int limit, int[][] queries)
		{
			int[] results = new int[queries.Length];
			Dictionary<int, int> currentColor = new Dictionary<int, int>();
			Dictionary<int, int> numberWithColor = new Dictionary<int, int>();
			int distinctColors = 0;
			for (int i = 0; i<queries.Length; i++)
			{
				if (currentColor.ContainsKey(queries[i][0]))
				{
					numberWithColor[currentColor[queries[i][0]]]--;
					if (numberWithColor[currentColor[queries[i][0]]] == 0) {
						distinctColors--;
					}
				}
				currentColor[queries[i][0]] = queries[i][1];
				if (!numberWithColor.ContainsKey(queries[i][1]) || numberWithColor[queries[i][1]] == 0)
				{
					distinctColors++;
					numberWithColor[queries[i][1]] = 1;
				}
				else
				{
					numberWithColor[queries[i][1]]++;
				}
				results[i] = distinctColors;
			}
			
			return results;
		}
	}
}
