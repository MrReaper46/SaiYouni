using System.Collections.Generic;
using UnityEngine;

public class BaiTap4<T>
{
    private List<T> objects = new List<T>();

    public void Add(T obj)
    {
        objects.Add(obj);
        Debug.Log($"{obj} added into {obj.GetType()} list!");
    }
    public void Remove(T obj)
    {
        Debug.Log($"Remove {obj}");
        if (objects.Contains(obj))
        {
            objects.Remove(obj);
            Debug.Log($"{obj} removed from {obj.GetType()} list");
        }
        else
        {
            Debug.Log($"{obj} is not in the {obj.GetType()} list");
        }
    }
}
