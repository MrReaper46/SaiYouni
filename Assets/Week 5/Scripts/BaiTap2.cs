using System;
using System.Collections;
using UnityEngine;

public class BaiTap2 : MonoBehaviour
{
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        Debug.Log($"So sanh day sau: {String.Join(",",array)}");
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array is empty or null.");
        }

        T max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i];
            }
        }
        Debug.Log($"Phan tu lon nhat trong mang la: {max}");
        return max;
    }
}