using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
    private void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    // Sort Algorithm 2
    private void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    // Sort Algorithm 3
    private void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
    // Sort Algorithm 4
    private void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    private void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[middle + 1 + j];

        int x = 0, y = 0;
        int k = left;

        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
            {
                array[k] = leftArray[x];
                x++;
            }
            else
            {
                array[k] = rightArray[y];
                y++;
            }
            k++;
        }

        while (x < n1)
        {
            array[k] = leftArray[x];
            x++;
            k++;
        }

        while (y < n2)
        {
            array[k] = rightArray[y];
            y++;
            k++;
        }
    }
    // Sort Algorithm 5
    private void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
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
    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        Debug.Log("Array: "  + string.Join(", ", randomNumbers));
        Debug.Log("=============================");
        //----------------------Edit below --------------------
        //Insert Algorithm here
        BubbleSort(randomNumbers);
        Debug.Log("BubbleSort Array: " + string.Join(", ", randomNumbers) + " - Time: " + Time.fixedDeltaTime);
        Debug.Log("=============================");
        SelectionSort(randomNumbers);
        Debug.Log("SelectionSort Array: " + string.Join(", ", randomNumbers) + " - Time: " + Time.fixedDeltaTime);
        Debug.Log("=============================");
        InsertionSort(randomNumbers);
        Debug.Log("InsertionSort Array: " + string.Join(", ", randomNumbers) + " - Time: " + Time.fixedDeltaTime);
        Debug.Log("=============================");
        QuickSort(randomNumbers, 0, randomNumbers.Length - 1);
        Debug.Log("QuickSort Array: " + string.Join(", ", randomNumbers) + " - Time: " + Time.fixedDeltaTime);
        Debug.Log("=============================");
        MergeSort(randomNumbers, 0, randomNumbers.Length - 1);
        Debug.Log("MergeSort Array: " + string.Join(", ", randomNumbers) + " - Time: " + Time.fixedDeltaTime);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
