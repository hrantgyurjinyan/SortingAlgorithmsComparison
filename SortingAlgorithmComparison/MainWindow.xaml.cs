// This file contains the logic for the MainWindow of the application

// Namespace, MainWindow class, and methods

using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;


namespace SortingAlgorithmComparison
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SortAllButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputArrayTextBox.Text;
            string[] inputArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out array[i]))
                {
                    MessageBox.Show("Invalid input. Please enter integers separated by spaces or commas.");
                    return;
                }
            }

            string result = "";

            result += "Insertion Sort:\n";
            result += SortAndMeasureTime(new InsertionSortTemplate(new InsertionSort()), array);

            result += "\nQuick Sort:\n";
            result += SortAndMeasureTime(new QuickSortTemplate(new QuickSort()), array);

            result += "\nHeap Sort:\n";
            result += SortAndMeasureTime(new HeapSortTemplate(new HeapSort()), array);

            OutputTextBlock.Text = result;
        }

        private string SortAndMeasureTime(SortTemplate sorter, int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                sorter.Sort(array);
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message + "\n";
            }

            stopwatch.Stop();

            string result = $"Sorted Array: {string.Join(", ", array)}\n";
            result += $"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds\n";

            return result;
        }

        private void InputArrayTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Please provide numbers to sort")
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void InputArrayTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Please provide numbers to sort";
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
    }
}
