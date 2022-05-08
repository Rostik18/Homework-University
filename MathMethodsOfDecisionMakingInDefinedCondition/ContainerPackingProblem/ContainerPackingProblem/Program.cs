using BenchmarkDotNet.Running;
using ContainerPackingProblem;

var summary = BenchmarkRunner.Run<AlgorithmsWithoutOrderingBenchmarks>();

//var elements = new int[]
//{
//    53,66,97,48,47,72,16,86,12,59,77,51,53,97,32,03,35,51,07,98,
//    49,54,61,06,34,03,25,84,28,97,63,33,15,60,81,14,85,97,51,97,
//    08,29,49,13,79,34,16,14,85,75,65,86,30,26,92,16,29,69,52,09
//};

//var minContainers = AlgorithmsWithoutOrdering.MinContainersNeed(elements); // 29

//var first = AlgorithmsWithoutOrdering.NFA(elements);
//var second = AlgorithmsWithoutOrdering.FFA(elements);
//var third = AlgorithmsWithoutOrdering.WFA(elements);
//var fourth = AlgorithmsWithoutOrdering.BFA(elements);

//Console.WriteLine();


//|          Method |      Mean |     Error |    StdDev | Allocated |
//| --------------- | -------- :| ---------:| ---------:| ---------:|
//| NFA_100elements | 3.042 us  | 0.0584 us | 0.0780 us | 8 KB      |
//| FFA_100elements | 19.215 us | 0.1473 us | 0.1306 us | 28 KB     |
//| WFA_100elements | 52.241 us | 0.8813 us | 0.8244 us | 75 KB     |
//| BFA_100elements | 48.619 us | 0.3212 us | 0.2682 us | 70 KB     |
