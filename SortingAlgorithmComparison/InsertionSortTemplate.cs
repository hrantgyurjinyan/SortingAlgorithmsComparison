// This class represents a template for insertion sort algorithm
public class InsertionSortTemplate : SortTemplate
{
    public InsertionSortTemplate(ISortAlgorithm algorithm) : base(algorithm)
    {
    }

    public override void Sort(int[] array)
    {
        SortTemplateMethod(array); // Calls the common sorting template method
    }
}
