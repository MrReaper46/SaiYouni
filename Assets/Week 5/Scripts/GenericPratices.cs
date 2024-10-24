using UnityEngine;

public class GenericPratices : MonoBehaviour
{
    [SerializeField] protected int randomIntA;
    [SerializeField] protected int randomIntB;
    [SerializeField] protected int[] randomIntArr;
    [SerializeField] protected float randomFloatA;
    [SerializeField] protected float randomFloatB;
    [SerializeField] protected float[] randomFloatArr;
    [SerializeField] protected string randomStringA;
    [SerializeField] protected string randomStringB;
    [SerializeField] protected string[] randomStringArr;
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    void Start()
    {
        //Ở bài tập này bạn hãy tạo nhiều class riêng biệt nha
        //Mối script một class nhé
        GenerateRandom();
        int baitapnumber = 0;
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap1Script();
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap2Script();
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap3Script();
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap4Script();
        Debug.Log($"====Bai Tap: {baitapnumber += 1}");
        BaiTap5Script();
    }

    private void GenerateRandom()
    {
        randomIntA = Random.Range(0, 100);
        randomIntB = Random.Range(0, 100);
        randomFloatA = Random.Range(0, 100);
        randomFloatB = Random.Range(0, 100);
        int randomLength = Random.Range(5, 10);
        randomIntArr = new int[randomLength];
        randomFloatArr = new float[randomLength];
        randomStringArr = new string[randomLength];
        for (int i = 0; i <= randomLength - 1; i++)
        {
            randomIntArr[i] = Random.Range(0, 100);
        }
        for (int i = 0; i <= randomLength - 1; i++)
        {
            randomFloatArr[i] = Random.Range(0.0f, 100.0f);
        }
        randomStringA = GenerateRandomString(randomLength);
        randomStringB = GenerateRandomString(randomLength);
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
        baiTap1Int.StoreValue(randomIntA);
        BaiTap1<float> baiTap1Float = new BaiTap1<float>();
        baiTap1Float.StoreValue(randomFloatA);
        BaiTap1<string> baiTap1String = new BaiTap1<string>();
        baiTap1String.StoreValue(randomStringA);
    }
    private void BaiTap2Script()
    {
        BaiTap2.FindMax<int>(randomIntArr);
        BaiTap2.FindMax<float>(randomFloatArr);
        BaiTap2.FindMax<string>(randomStringArr);
    }
    private void BaiTap3Script()
    {
        BaiTap3.Swap<int>(ref randomIntA, ref randomIntB);
        BaiTap3.Swap<float>(ref randomFloatA, ref randomFloatB);
        BaiTap3.Swap<string>(ref randomStringA, ref randomStringB);
    }
    private void BaiTap4Script()
    {
        BaiTap4<int> baiTap4Int = new BaiTap4<int>();
        for (int i = 0; i < randomIntArr.Length; i++)
        {
            baiTap4Int.Add(randomIntArr[i]);
        }
        baiTap4Int.Remove(randomIntArr[Random.Range(0, randomIntArr.Length)]);

        BaiTap4<float> baiTap4Float = new BaiTap4<float>();
        for (int i = 0; i < randomFloatArr.Length; i++)
        {
            baiTap4Float.Add(randomFloatArr[i]);
        }
        baiTap4Float.Remove(randomFloatArr[Random.Range(0, randomFloatArr.Length)]);

        BaiTap4<string> baiTap4String = new BaiTap4<string>();
        for (int i = 0; i < randomStringArr.Length; i++)
        {
            baiTap4String.Add(randomStringArr[i]);
        }
        baiTap4String.Remove(randomStringArr[Random.Range(0, randomStringArr.Length)]);
    }
    private void BaiTap5Script()
    {
        int randomInttoCheck = Random.Range(0, 100);
        Debug.Log($"Danh sach chua {randomInttoCheck}: {BaiTap5.ContainsElement<int>(randomIntArr, randomInttoCheck)}");
        int randomIntfromArr = randomIntArr[Random.Range(0, randomIntArr.Length)];
        Debug.Log($"Danh sach chua {randomIntfromArr}: {BaiTap5.ContainsElement<int>(randomIntArr, randomIntfromArr)}");

        float randomFloattoCheck = Random.Range(0, 100);
        Debug.Log($"Danh sach chua {randomFloattoCheck}: {BaiTap5.ContainsElement<float>(randomFloatArr, randomFloattoCheck)}");
        float randomFloatfromArr = randomFloatArr[Random.Range(0, randomFloatArr.Length)];
        Debug.Log($"Danh sach chua {randomFloatfromArr}: {BaiTap5.ContainsElement<float>(randomFloatArr, randomFloatfromArr)}");

        string randomStringtoCheck = GenerateRandomString(5);
        Debug.Log($"Danh sach chua {randomStringtoCheck}: {BaiTap5.ContainsElement<string>(randomStringArr, randomStringtoCheck)}");
        string randomStringfromArr = randomStringArr[Random.Range(0, randomIntArr.Length)];
        Debug.Log($"Danh sach chua {randomStringfromArr}: {BaiTap5.ContainsElement<string>(randomStringArr, randomStringfromArr)}");
    }
}
