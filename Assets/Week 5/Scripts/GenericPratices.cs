using UnityEngine;
using UnityEngine.UIElements;

public class GenericPratices : MonoBehaviour
{
    [SerializeField] protected int randomInt;
    [SerializeField] protected int[] randomIntArr;
    [SerializeField] protected float randomFloat;
    [SerializeField] protected float[] randomFloatArr;
    [SerializeField] protected string randomString;
    [SerializeField] protected string[] randomStringArr;
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    void Start()
    {
        //Ở bài tập này bạn hãy tạo nhiều class riêng biệt nha
        //Mối script một class nhé
        int baitapnumber = 0;
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap1Script();
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap2Script();
    }

    private void GenerateRandom()
    {
        randomInt = Random.Range(0, 100);
        randomFloat = Random.Range(0, 100);
        int randomLength = Random.Range(5, 10);
        for (int i = 0; i <= randomLength - 1; i++)
        {
            randomIntArr[i] = Random.Range(0, 100);
        }
        for (int i = 0; i <= randomLength - 1; i++)
        {
            randomFloatArr[i] = Random.Range(0, 100);
        }
        randomString = GenerateRandomString(randomLength);
        int minStringLength = 5;
        int maxStringLength = 15;
        randomStringArr = GenerateRandomStringArray(randomLength, minStringLength, maxStringLength);
    }
    public static string GenerateRandomString(int length)
    {
        char[] stringChars = new char[length];
        System.Random random = new System.Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }
    public static string[] GenerateRandomStringArray(int arrayLength, int minStringLength, int maxStringLength)
    {
        string[] randomStrings = new string[arrayLength];
        System.Random random = new System.Random();

        for (int i = 0; i < arrayLength; i++)
        {
            int randomLength = random.Next(minStringLength, maxStringLength + 1);
            randomStrings[i] = GenerateRandomString(randomLength);
        }

        return randomStrings;
    }
    private void BaiTap1Script()
    {
        BaiTap1<int> baiTap1Int = new BaiTap1<int>();
        baiTap1Int.StoreValue(25);
        BaiTap1<float> baiTap1Float = new BaiTap1<float>();
        baiTap1Float.StoreValue(10.55f);
        BaiTap1<string> baiTap1String = new BaiTap1<string>();
        baiTap1String.StoreValue("Hello World!");
    }
    private void BaiTap2Script()
    {
    }
}
