using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTap1 <T>
{
    private T value;
    public void StoreValue (T value)
    {
        this.value = value; 
        Debug.Log($"Type: {value.GetType()} - Value: {value}");
    }
}
