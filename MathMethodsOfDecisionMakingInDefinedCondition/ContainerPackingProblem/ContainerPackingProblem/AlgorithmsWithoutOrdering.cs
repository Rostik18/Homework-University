
namespace ContainerPackingProblem
{
    static class AlgorithmsWithoutOrdering
    {
        const int ContainerCapacity = 100;

        public static int MinContainersNeed(IEnumerable<int> elements) => elements.Sum() / ContainerCapacity;

        // Next Fit Algorithm
        public static List<int[]> NFA(IEnumerable<int> elements)
        {
            var containers = new List<int[]>();
            var container = new List<int>();

            foreach (var element in elements)
            {
                if (container.Sum() + element > ContainerCapacity)
                {
                    containers.Add(container.ToArray());
                    container = new List<int>();
                }

                container.Add(element);
            }

            return containers;
        }

        // First Fit Algorithm
        public static List<List<int>> FFA(IEnumerable<int> elements)
        {
            var containers = new List<List<int>>();

            foreach (var element in elements)
            {
                var i = containers.Count - 1;
                for (; i >= 0; i--)
                {
                    if (containers[i].Sum() + element <= ContainerCapacity)
                    {
                        containers[i].Add(element);
                        break;
                    }
                }
                if (i == -1)
                {
                    containers.Add(new List<int> { element });
                }
            }

            return containers;
        }

        // Worst Fit Algorithm
        public static List<List<int>> WFA(IEnumerable<int> elements)
        {
            var containers = new List<List<int>> { new List<int>() };

            foreach (var element in elements)
            {
                var mostFreeContainer = containers.Last();

                if (mostFreeContainer.Sum() + element <= ContainerCapacity)
                {
                    mostFreeContainer.Add(element);
                }
                else
                {
                    for (var i = containers.Count - 1; i >= 0; i--)
                    {
                        if (containers[i].Sum() < mostFreeContainer.Sum())
                        {
                            mostFreeContainer = containers[i];
                        }
                    }

                    if (mostFreeContainer.Sum() + element <= ContainerCapacity)
                    {
                        mostFreeContainer.Add(element);
                    }
                    else
                    {
                        mostFreeContainer = new List<int> { element };
                        containers.Add(mostFreeContainer);
                    }
                }
            }

            return containers;
        }

        // Best Fit Algorithm
        public static List<List<int>> BFA(IEnumerable<int> elements)
        {
            var containers = new List<List<int>> { new List<int>() };

            foreach (var element in elements)
            {
                var bestContainer = containers.Last();

                if (bestContainer.Sum() + element <= ContainerCapacity)
                {
                    bestContainer.Add(element);
                }
                else
                {
                    var minFreeCapacity = 0;
                    for (var i = containers.Count - 1; i >= 0; i--)
                    {
                        if (containers[i].Sum() > minFreeCapacity && containers[i].Sum() + element <= ContainerCapacity)
                        {
                            minFreeCapacity = containers[i].Sum();
                            bestContainer = containers[i];
                        }
                    }

                    if (bestContainer.Sum() + element <= ContainerCapacity)
                    {
                        bestContainer.Add(element);
                    }
                    else
                    {
                        bestContainer = new List<int> { element };
                        containers.Add(bestContainer);
                    }
                }
            }

            return containers;
        }
    }
}
