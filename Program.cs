using System;
using Algorithms;
using System.Collections.Generic;

Algorithms.Class1 sortingAlgorithms = new Algorithms.Class1();

Console.WriteLine("Sorting Algorithm Comparison");
Console.WriteLine("----------------------------");

// Menu for selecting a sorting algorithm
Console.WriteLine("Select a sorting algorithm:");
Console.WriteLine("1. Insertion Sort");
Console.WriteLine("2. Selection Sort");
Console.WriteLine("3. Bubble Sort");
Console.WriteLine("4. Merge Sort");
Console.WriteLine("5. Quick Sort");
Console.WriteLine("6. Sort By Lambda");
Console.Write("Enter your choice (1-6): ");

string choice = Console.ReadLine();
if (int.TryParse(choice, out int algorithmChoice) && algorithmChoice >= 1 && algorithmChoice <= 6)
{
    // Get the selected sorting algorithm
    string selectedAlgorithm = GetAlgorithmName(algorithmChoice);

    // Get array size from user
    Console.Write("Enter array size: ");
    if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
    {
        // Prepare the array
        int[] array = Algorithms.Class1.Prepare(arraySize);

        // Get the sorting delegate for the selected algorithm
        Algorithms.Class1.SortingDelegate sortingDelegate = GetSortingDelegate(selectedAlgorithm);

        // Run the sorting algorithm and measure the running time
        Algorithms.Class1.DisplayRunningTime(array, sortingDelegate, selectedAlgorithm);

        // Display the running time
        Console.WriteLine($"{selectedAlgorithm} - Running Time: {sortingAlgorithms.ElapsedTime} milliseconds");
    }
    else
    {
        Console.WriteLine("Invalid array size. Please enter a positive integer.");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
}

string GetAlgorithmName(int choice)
{
    switch (choice)
    {
        case 1:
            return "InsertionSort";
        case 2:
            return "SelectionSort";
        case 3:
            return "BubbleSort";
        case 4:
            return "MergeSort";
        case 5:
            return "QuickSort";
        case 6:
            return "LambdaSort";
        default:
            return "";
    }
}

Algorithms.Class1.SortingDelegate GetSortingDelegate(string algorithm)
{
    switch (algorithm)
    {
        case "InsertionSort":
            return Algorithms.Class1.InsertionSort;
        case "SelectionSort":
            return Algorithms.Class1.SelectionSort;
        case "BubbleSort":
            return Algorithms.Class1.BubbleSort;
        case "MergeSort":
            return Algorithms.Class1.MergeSort;
        case "QuickSort":
            return Algorithms.Class1.QuickSort;
        case "SortByLambda":
            return Algorithms.Class1.LambdaSort;
            default:
            return null;
    }
}
