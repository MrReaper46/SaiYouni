using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tính giai thừa của một số
        BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3(); // Chuỗi Fibonacci
        BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        // Nhập số nguyên dương n từ bàn phím
        int n = Random.Range(0, 100);
        BigInteger result = Factorial(n);
        // Viết hàm đệ quy để tính giai thừa của n
        BigInteger Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        Debug.Log($"Bai Tap 1: Giai thua của \"{n}\" la: {result}");
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        int n = Random.Range(0, 100);
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        int result = Sum(n);
        Debug.Log($"Bai Tap 2: Tong cac so tu 1 to \"{n} \" la: {result}");
        int Sum(int n)
        {
            if (n <= 1)
                return n;
            return n + Sum(n - 1);
        }
    }

    

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        int n = 10;
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        int result = Fibonacci(n);
        Debug.Log($"Bai Tap 3: Fibonacci thứ {n}: {result}");
        int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        int n = 10;
        Debug.Log("Bai Tap 4: Bat dau dem nguoc");
        CountDown(n);
        // Viết hàm đệ quy để đếm ngược từ n về 1
        void CountDown(int n)
        {
            if (n <= 0)
            {
                Debug.Log("Countdown finished!");
                return;
            }
            Debug.Log(n);
            CountDown(n - 1);
        }
}

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);
        int result = GCD(a, b);
        Debug.Log($"Bai Tap 5: UCLN cua {a} va {b} la: {result}");
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
}
