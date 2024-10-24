using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap3 : MonoBehaviour
{
    public static void Swap<T>(ref T a, ref T b)
    {
        Debug.Log($"Ban dau: a = {a} / b = {b}");
        T temp = a;
        a = b;
        b = temp;
        Debug.Log($"Sau khi doi: a = {a} / b  = {b}");
    }
}
