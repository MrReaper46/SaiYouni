using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int
        int maxInt = 0;
        int[] arrayInt = new int[10];
        for (int i = 0; i < arrayInt.Length; i++)
        {
            arrayInt[i] = Random.Range(1, 100);
        }
        maxInt = Mathf.Max(arrayInt);
        Debug.Log("Tìm giá trị lớn nhất của dãy số sau: " + string.Join(", ", arrayInt));
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float
        float maxFloat = 0f;
        float[] arrayFloat = new float[10];
        for (int i = 0; i < arrayFloat.Length; i++)
        {
            arrayFloat[i] = Random.Range(1.0f, 100.0f);
        }
        maxFloat = Mathf.Max(arrayFloat);
        Debug.Log("Tìm giá trị lớn nhất của dãy số Int sau: " + string.Join(", ", arrayFloat));
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double
        double maxDouble;
        double[] arrayDouble = new double[10];
        for (int i = 0; i < arrayDouble.Length; i++)
        {
            arrayDouble[i] = Random.Range(1.0f, 100.0f);
        }
        maxDouble = arrayDouble[0];
        for (int i = 1; i < arrayDouble.Length; i++)
        {
            if (arrayDouble[i] > maxDouble)
            {
                maxDouble = arrayDouble[i];
            }
        }
        Debug.Log("Tìm giá trị lớn nhất của dãy số Int sau: " + string.Join(", ", arrayDouble));
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }

}
