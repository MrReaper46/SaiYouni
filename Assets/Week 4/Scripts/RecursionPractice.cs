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
        BigInteger result = 1;
        // Viết hàm đệ quy để tính giai thừa của n
        if (n == 0 || n == 1) result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        Debug.Log($"Bai Tap 1: Giai thua của \"{n}\" la: {result}");
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        int n = Random.Range(0, 100);
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Debug.Log($"Bai Tap 2: Tong cac so tu 1 den {n}: {sum}");
    }

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
    }
}
