﻿// Quick Sort algorithm implementation

public class QuickSort : ISortAlgorithm
{
    public void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    private void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);

            Sort(array, low, pi - 1);
            Sort(array, pi + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;

                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }
}
