// Template for Quick Sort

public class QuickSortTemplate : SortTemplate
{
    public QuickSortTemplate(ISortAlgorithm algorithm) : base(algorithm)
    {
    }

    public override void Sort(int[] array)
    {
        SortTemplateMethod(array);
    }
}
