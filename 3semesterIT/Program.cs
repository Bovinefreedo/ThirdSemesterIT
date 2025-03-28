using System.Globalization;
using ThirdSemesterIT.A10Search;
using ThirdSemesterIT.A1Recurssion;
using ThirdSemesterIT.A2FunctionalProgramming;
using ThirdSemesterIT.B1Leetcode;

Search.InitSortedArray(
                new int[] { 2, 4, 8, 10, 15, 17, -1, -1, -1, -1 },
                6
            );
Search.InsertSorted(11);


Console.WriteLine(string.Join(", ", Search.sortedArray));