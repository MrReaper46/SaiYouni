using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In Các Số Từ 1 Đến 100
        BaiTap2(); // Tính Tổng Các Số Từ 1 Đến 50
        BaiTap3(); // In Các Số Chẵn Từ 1 Đến 100
        BaiTap4(); // Tính Tích Các Số Từ 1 Đến 10
        BaiTap5(); // Tìm Số Lớn Nhất Trong Một Mảng
        BaiTap6(); // Tính Tổng Các Số Lẻ Từ 1 Đến 100
        BaiTap7(); // Đảo Ngược Chuỗi
        BaiTap8(); // In Ra Bảng Cửu Chương
        BaiTap9(); // Đếm Các Số Nguyên Dương Trong Mảng
        BaiTap10(); // In Tam Giác Số
        BaiTap11(); // Tìm Phần Tử Nhỏ Nhất Trong Mảng
        BaiTap12(); // In Dãy Fibonacci
        BaiTap13(); // Tính Giai Thừa Của Một Số
        BaiTap14(); // In Ra Các Số Nguyên Từ n Đến 1
        BaiTap15(); // Tính Tổng Các Phần Tử Trong Mảng
        BaiTap16(); // Kiểm Tra Số Nguyên Tố
        BaiTap17(); // In Ra Dãy Số Chia Hết Cho 3
        BaiTap18(); // Tìm Tổng Các Số Chẵn Trong Mảng
        BaiTap19(); // Tính Trung Bình Cộng Của Mảng
        BaiTap20(); // Đếm Số Ký Tự Hoa Trong Chuỗi
    }

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        List<int> intArray = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            intArray.Add(i);
        }
        Debug.Log("Bai Tap 1: " + string.Join(",", intArray));
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        int sum = 0;

        for (int i = 1; i <= 50; i++)
        {
            sum += i;
        }

        Debug.Log("Bai Tap 2: " + sum);
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        List<int> intArray = new List<int>();

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                intArray.Add(i);
            }
        }

        Debug.Log("Bai Tap 3: " + string.Join(",", intArray));
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        int product = 1;

        for (int i = 1; i <= 10; i++)
        {
            product *= i;
        }

        Debug.Log("Bai Tap 4: " + product);
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        int[] intArr = new int[10];
        for (int i = 0; i <= 9; i++)
        {
            intArr[i] = Random.Range(0, 100);
        }

        int max = intArr[0];
        foreach (int number in intArr)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Debug.Log("Bai Tap 5: Array [" + string.Join(",", intArr) + "] ==> max =" + max);
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        Debug.Log("Bai Tap 6: " + sum);
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        string original = "Unity";
        string reversed = ReverseString(original);
        string ReverseString(string input)
        {
            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }
        Debug.Log($"Bai Tap 7: \n Chuoi goc: {original} - Chuoi dao: {reversed}");
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        Debug.Log("Bai Tap 8:");
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("Bảng cửu chương " + i + ":");

            for (int j = 1; j <= 10; j++)
            {
                Debug.Log(i + " x " + j + " = " + (i * j));
            }
            Debug.Log("--------------------------");
        }
    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        int[] numbers = new int[Random.Range(10,20)];
        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            numbers[i] = Random.Range(-100, 100);
        }
        int count = 0;
        for(int i = 0; i <= numbers.Length - 1; i++)
        {
            if(numbers[i] > 0)
            {
                count++;
            }
        }
        Debug.Log("Bai Tap 9: Chuoi [" + string.Join(",  ", numbers) + "] - Co " + count + " so duong trong mang");
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            string line = "";

            for (int j = 1; j <= i; j++)
            {
                line += j + " ";
            }

            Debug.Log(line);
        }
    }

    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        int[] intArr = new int[10];
        for (int i = 0; i <= 9; i++)
        {
            intArr[i] = Random.Range(0, 100);
        }

        int min = intArr[0];

        for (int i = 0; i <= 9; i++)
        {
            if(intArr[i] < min)
            {
                min = intArr[i];
            }
        }
        Debug.Log("Bai Tap 11: Array [" + string.Join(",", intArr) + "] ==> min =" + min);
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        int n = Random.Range(10, 20);
        int a = 0;
        int b = 1;
        List<int> FibonacciNumbers = new List<int>();
        FibonacciNumbers.Add(a);
        for (int i = 0; i<= n - 1; i++)
        {
            int next = a + b;
            a = b;
            b = next;
            FibonacciNumbers.Add(next);
        }
        Debug.Log($"Bai Tap 12: Day so Fibonacci {n} so: {string.Join(",",FibonacciNumbers)}");
    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        int number = Random.Range(0, 100);
        long facto = 1;
        for (int i = 1; i <= number; i++)
        {
            facto *= i;
        }
        Debug.Log($"Bai Tap 13: Giai Thua So {number} là {facto}");
    }

    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        int[] intArr = new int[Random.Range(10,20)];

        for (int i = 0; i <= intArr.Length-1; i++)
        {
            intArr[i] = intArr.Length - i;
        }
        Debug.Log($"Bai Tap 14: [{string.Join(",", intArr)}]");
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        int[] intArr = new int[Random.Range(10, 20)];
        int sum = 0;
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            intArr[i] = Random.Range(0, 100);
        }
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            sum += intArr[i];
        }
        Debug.Log($"Bai Tap 15: Tong cua mang [{string.Join(",", intArr)}] la {sum}");
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        int number = Random.Range(0,200);
        if(number < 2)
        {
            Debug.Log($"Bai Tap 16: so {number} la khong phai la so nguyen");
        }
        for (int i = 2; i <= Mathf.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Debug.Log($"Bai Tap 16: so {number} la khong phai la so nguyen");
            }
            else
            {
                Debug.Log($"Bai Tap 16: so {number} la phai la so nguyen");
            }

        }

    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        int[] intArr = new int[Random.Range(10, 20)];
        int GenerateNumberMultipliedbyThree(int min, int max)
        {
            int randomNum;

            do
            {
                randomNum = Random.Range(min, max);
            }
            while (randomNum % 3 != 0);

            return randomNum;
        }
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            intArr[i] = GenerateNumberMultipliedbyThree(0, int.MaxValue);
        }
        Debug.Log($"Bai Tap 17: Day so chia het cho 3 [{string.Join(", ", intArr)}]");
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        int[] intArr = new int[Random.Range(10, 20)];
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            intArr[i] = Random.Range(0, 100);
        }
        int sum = 0;
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            if (intArr[i] % 2 == 0)
            {
                sum += intArr[i];
            }
        }
        Debug.Log($"Bai Tap 18: Tong cac so chan trong day [{string.Join(", ", intArr)}] la {sum}");
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        int[] intArr = new int[Random.Range(10, 20)];
        int sum = 0;
        for (int i = 0; i <= intArr.Length - 1; i++)
        {
            intArr[i] = Random.Range(0, 100);
            sum += intArr[i];
        }
        float intAvg = (float)sum / intArr.Length;
        Debug.Log($"Bai Tap 19: Trung binh cong cua day [{string.Join(", ", intArr)}] la {intAvg}");
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        string inputString = "Hello World! UNITY is Fun.";
        int uppercaseCount = CountUppercaseLetters(inputString);
        int CountUppercaseLetters(string str)
        {
            int count = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    count++;
                }
            }

            return count;
        }
        Debug.Log($"Bai Tap 19: So ky tu Hoa trong chuoi \"{inputString}\" la {uppercaseCount} ky tu");
    }
}
