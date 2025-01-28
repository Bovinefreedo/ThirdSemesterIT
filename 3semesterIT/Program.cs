using ThirdSemesterIT.B1Leetcode;
using ThirdSemesterIT.A1Recurssion;

int[] greedyKids = new int[4] { 10, 9, 8, 7 };
int[] cookieSize = new int[4] { 5, 6, 7, 8 };

Q455GreedyCookieDistribution prob = new();

Console.WriteLine($"number of satisfied kids: {prob.FindContentChildren(greedyKids, cookieSize)}");