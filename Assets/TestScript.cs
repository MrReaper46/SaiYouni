using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] protected int[] randomIntArr;
    void Start()
    {
        int randomLength = Random.Range(5, 10);
        Debug.Log(randomLength);
        randomIntArr = new int[randomLength];
        for (int i = 0; i < randomLength; i++)
        {
            randomIntArr[i] = Random.Range(0, 100);
        }
        Debug.Log(string.Join(", ", randomIntArr));
    }
}
