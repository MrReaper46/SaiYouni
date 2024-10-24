using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap5 : MonoBehaviour
{
    public static bool ContainsElement<T>(T[] array, T element)
    {
        foreach (T item in array)
        {
            if (item.Equals(element))
            {
                return true;
            }
        }
        return false;
    }
}
