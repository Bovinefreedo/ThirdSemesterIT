using ThirdSemesterIT.B1Leetcode;
using ThirdSemesterIT.A1Recurssion;

Q475Heaters heaters = new Q475Heaters();

int[] house = new int[30000];
int[] heater = new int[30000];

for (int i = 0; i < 30000; i++)
{
    house[i] = i + 1;
    heater[i] = i + 1;
}
house[29999] = 2999;
heater[29999] = 2999;

Console.WriteLine(heaters.FindRadius(house, heater));