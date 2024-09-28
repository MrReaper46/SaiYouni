using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 25, 30, 5, 50, 100, 75 };
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 25, 30, 5, 50, 100, 75 };
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        List<string> words = new List<string> { "apple", "banana", "cherry", "dragonfruit", "elderberry" };
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string longestString = "";
        foreach (string word in words)
        {
            if (word.Length > longestString.Length)
            {
                longestString = word;
            }
        }
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 != 0) // Kiểm tra nếu số là lẻ
            {
                sum += number; // Cộng số lẻ vào tổng
            }
        }
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Kiểm tra nếu số là chẵn
            {
                Debug.Log(number); // In số chẵn ra console
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 5;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        bool exists = false;
        foreach (int number in numbers)
        {
            if (number == target)
            {
                exists = true;
                break;
            }
        }
        if (exists)
        {
            Debug.Log("Phần tử " + target + " tồn tại trong mảng.");
        }
        else
        {
            Debug.Log("Phần tử " + target + " không tồn tại trong mảng.");
        }

    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -1, 2, -3, 4, -5, 6, -7, 8, 9, -10 };
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int negativeCount = 0;
        foreach (int number in numbers)
        {
            if (number < 0) // Kiểm tra nếu số là âm
            {
                negativeCount++; // Tăng biến đếm nếu số âm
            }
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 12, 7, 15, 3, 20, 8, 11, 25 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int number in numbers)
        {
            if (number > 10)
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        List<string> words = new List<string> { "apple", "banana", "kiwi", "grape", "watermelon" };
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string shortestString = words[0];
        foreach (string word in words)
        {
            if (word.Length < shortestString.Length)
            {
                shortestString = word;
            }
        }
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            int doubled = number * 2;
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 3, 1, 4, 4, 5, 5, 2, 6 };
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int largest = numbers[0]; 
        int secondLargest;
        foreach (int number in numbers)
        {
            // Cập nhật số lớn nhất và số lớn thứ hai
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        List<string> words = new List<string> { "Apple", "Banana", "Avocado", "Cherry", "Apricot", "Grape" };
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        List<string> results = new List<string>();
        foreach (string word in words)
        {
            if (word.StartsWith("A", System.StringComparison.OrdinalIgnoreCase))
            {
                results.Add(word);
            }
        }
        if (results.Count > 0)
        {
            Debug.Log("Các chuỗi bắt đầu bằng chữ cái 'A': " + string.Join(", ", results));
        }
        else
        {
            Debug.Log("Không có chuỗi nào bắt đầu bằng chữ cái 'A'.");
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        List<string> words = new List<string> { "apple", "Hell", "kiwi", "Helo", "orange", "HelIo" };
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        string targetString = "Hello";
        if (words.Contains(targetString))
        {
            Debug.Log("Danh sách chứa chuỗi: " + targetString);
        }
        else
        {
            Debug.Log("Danh sách không chứa chuỗi: " + targetString);
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -5, 3, -2, 8, -1, 0, 7, -4, 10 };
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] numbers = { 1, 2, 3, 4, 2, 5, 2, 6, 7 };
        int target = 2;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int count = 0;
        foreach (int number in numbers)
        {
            if (number == target)
            {
                count++;
            }
        }
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 12, 7, 15, 3, 20, 8, 11, 25 };
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        List<int> greaterThanTen = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 10)
            {
                greaterThanTen.Add(number);
            }
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        List<string> words = new List<string> { "apple", "banana", "kiwi", "grapefruit", "orange", "peach", "strawberry" };
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string word in words)
        {
            if (word.Length > 5)
            {
                Debug.Log(word);
            }
        }
    }

}
