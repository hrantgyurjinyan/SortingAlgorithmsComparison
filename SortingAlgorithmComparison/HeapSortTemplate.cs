// Heap Sort template

public class HeapSortTemplate : SortTemplate
{
    public HeapSortTemplate(ISortAlgorithm algorithm) : base(algorithm)
    {
    }

    public override void Sort(int[] array)
    {
        SortTemplateMethod(array);
    }
}

