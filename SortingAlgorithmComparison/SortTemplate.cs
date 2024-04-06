// Abstract class representing a sort template
public abstract class SortTemplate
{
    protected ISortAlgorithm sortAlgorithm;

    public SortTemplate(ISortAlgorithm algorithm)
    {
        this.sortAlgorithm = algorithm;
    }

    public abstract void Sort(int[] array);

    protected void SortTemplateMethod(int[] array)
    {
        // Common code segment
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array is empty or null");

        // Call the algorithm specific sort
        sortAlgorithm.Sort(array);

        // Common code segment
        Console.WriteLine("Sorting completed using " + sortAlgorithm.GetType().Name);
    }
}
