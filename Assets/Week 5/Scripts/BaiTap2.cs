using System;
using System.Collections;
using UnityEngine;

public class BaiTap2 : MonoBehaviour
{
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
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

        return max;
    }
}