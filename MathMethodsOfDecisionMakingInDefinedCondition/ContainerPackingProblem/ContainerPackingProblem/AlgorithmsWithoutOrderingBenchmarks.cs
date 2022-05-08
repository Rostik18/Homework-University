﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace ContainerPackingProblem
{
    [MemoryDiagnoser(false)]
    public class AlgorithmsWithoutOrderingBenchmarks
    {
        private readonly int[] elements;

        public AlgorithmsWithoutOrderingBenchmarks()
        {
            elements = new int[]
            {
                53,66,97,48,47,72,16,86,12,59,77,51,53,97,32,03,35,51,07,98,
                49,54,61,06,34,03,25,84,28,97,63,33,15,60,81,14,85,97,51,97,
                08,29,49,13,79,34,16,14,85,75,65,86,30,26,92,16,29,69,52,09
            };
        }

        [Benchmark]
        public void NFA_100elements() => AlgorithmsWithoutOrdering.NFA(elements);

        [Benchmark]
        public void FFA_100elements() => AlgorithmsWithoutOrdering.FFA(elements);

        [Benchmark]
        public void WFA_100elements() => AlgorithmsWithoutOrdering.WFA(elements);

        [Benchmark]
        public void BFA_100elements() => AlgorithmsWithoutOrdering.BFA(elements);
    }
}
