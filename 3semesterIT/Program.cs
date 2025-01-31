using ThirdSemesterIT.B1Leetcode;
using ThirdSemesterIT.A1Recurssion;

Q475Heaters heaters = new Q475Heaters();
int[] houses = new int[4] { 1, 4, 8, 10 };
int[] heater = new int[3] { 2, 4, 7 };

Console.WriteLine(heaters.FindRadius(houses, heater));