using ThirdSemesterIT.A1Recurssion;

//Random random = new Random();
//List<int> ints = new List<int>();

//for (int i = 0; i < 100000; i++)
//{
//    ints.Add(random.Next(1, 10000));
//}

//QuickSort qs = new QuickSort();
//MergeSort ms = new MergeSort();
//List<int> sortedMerge = ms.mergeSort(ints);
//List<int> sorted = qs.quickSort(ints);

//Console.WriteLine($"The length of the list {sortedMerge.Count}");
//foreach (int i in sortedMerge)
//{
//    Console.WriteLine(i);
//}

TriangleSquare ts = new();

for (int i = 1;  i < 2000; i++) {
    Console.WriteLine(ts.numberOfSquaresInTriangle(i));
}