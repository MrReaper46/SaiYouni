using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        int number = Random.Range(-100, 100);
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (number == 0)
        {
            Debug.Log($"Bai Tap 1: {number} la so 0");
        }
        else if (number > 0)
        {
            Debug.Log($"Bai Tap 1: {number} la so duong");
        }
        else Debug.Log($"Bai Tap 1: {number} la so am");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        int number = Random.Range(0, 100);
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (number % 2 == 0)
        {
            Debug.Log($"Bai Tap 2: {number} la so chan");
        }
        else Debug.Log($"Bai Tap 2: {number} la so le");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = Random.Range(0, 10);
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (score >= 5.0f)
        {
            Debug.Log($"Bai Tap 3: Voi so diem la {score} - KQ: hoc sinh do");
        }
        else Debug.Log($"Bai Tap 3: Voi so diem la {score} - KQ: hoc sinh truot");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        int numberA = Random.Range(0, 100);
        int numberB = Random.Range(0, 100);
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (numberA == numberB)
        {
            Debug.Log($"Bai Tap 4: so thu nhat: \"{numberA}\" bang voi so thu hai: \"{numberB}\"");
        }
        else if (numberA < numberB)
        {
            Debug.Log($"Bai Tap 4: so thu nhat: \"{numberA}\" nho hon voi so thu hai: \"{numberB}\"");
        }
        else Debug.Log($"Bai Tap 4: so thu nhat: \"{numberA}\" lon hon voi so thu hai: \"{numberB}\"");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int balance = Random.Range(0, 1000);
        int price = Random.Range(0, 1000);
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (balance >= price)
        {
            Debug.Log($"Bai Tap 5: Voi so tien ${balance}, nguoi dung du tien mua mon hang voi gia ${price}");
        }
        else Debug.Log($"Bai Tap 5: Voi so tien ${balance}, nguoi dung khong du tien mua mon hang voi gia ${price}");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        int year = Random.Range(0, 2024);
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log($"Bai Tap 6: {year} la nam nhuan");
        }
        else Debug.Log($"Bai Tap 6: {year} khong phai la nam nhuan");
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        int age = Random.Range(0, 100);
        int ticket = 50000;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        if (age < 18)
        {
            ticket = 50000;
        }
        else ticket = 100000;
        Debug.Log($"Bai Tap 7: Tuoi khach hang: {age} - gia ve: {ticket}");
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 100.0f) * 0.01f;
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (score >= 9.0f)
        {
            Debug.Log($"Bai Tap 8: Diem trung binh:{score} - Hoc sinh dat loai xuat sac");
        }
        else Debug.Log($"Bai Tap 8: Diem trung binh: {score} - Hoc sinh chua dat loai xuat sac");
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);
        int c = Random.Range(0, 100);
        int[] intArr = { a, b, c };
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        int max = intArr[0];
        for (int i = 0; i < 3; i++)
        {
            if (intArr[i] > max)
            {
                max = intArr[i];
            }
        }
        Debug.Log($"Bai Tap 9: so lon nhat trong 3 so [{string.Join(", ", intArr)}] la so {max}");
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        float workHour = Random.Range(0.0f, 100.0f);
        const float wage = 50;
        float wageReceived = wage;
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        if (workHour <= 40.0f)
        {
            wageReceived = wage;
        }
        else wageReceived = wage + wage * (workHour - 40) / 100;
        Debug.Log($"Bai tap 10: So gio lam viec: {workHour} - Tong luong: {wageReceived}");
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int age = Random.Range(0, 100);
        bool isMember = Random.Range(0, 2) == 0;
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if (!isMember)
        {
            Debug.Log($"Bai tap 11: Tuoi khach hang: {age} - khong co the thanh vien => khong duoc vao clb");
        }
        else if (isMember && age <= 18)
        {
            Debug.Log($"Bai tap 11: Tuoi khach hang: {age} - co the thanh vien => khong duoc vao clb");
        }
        else Debug.Log($"Bai tap 11: Tuoi khach hang: {age} - co the thanh vien => duoc vao clb");
    }
    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 10.0f) * 0.1f;
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        string rank = "";
        if (score < 5.0)
        {
            rank = "Yeu";
        }
        else if (score >= 5.0 && score <= 6.5)
        {
            rank = "Trung binh";
        }
        else if (score > 6.5 && score < 8.0)
        {
            rank = "Kha";
        }
        else if (score > 8.0 && score <= 9.0)
        {
            rank = "Gioi";
        }
        else rank = "Xuat sac";
        Debug.Log($"Bai tap 12: Diem tb: {score} - Thanh tich: {rank}");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        float totalConsume = Random.Range(0, 1000);
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        float unitPrice;
        if (totalConsume <= 100)
        {
            unitPrice = 1500;
        }
        else unitPrice = 2000;
        float bill = totalConsume * unitPrice;
        Debug.Log($"Bai Tap 13: So dien tieu tu: {totalConsume}kWh - Tong tien dien: {bill}VND");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        int year = Random.Range(0, 30);
        bool revaluated = Random.Range(0, 2) == 0;
        string workRevaluation = "";
        string promotion = "";
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if (revaluated)
        {
            workRevaluation = "Tot";
        }
        else workRevaluation = "Khong tot";
        if (year > 5 && revaluated)
        {
            promotion = "duoc thang chuc";
        }
        else promotion = "khong duoc thang chuc";
        Debug.Log($"Bai Tap 14: So nam lam viec: {year} nam - Danh gia cong viec: {workRevaluation} => {promotion}");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        int price = Random.Range(1000, 10000000);
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        string freeShipping = "";
        if (price >= 500000)
        {
            freeShipping = "mien phi";
        }
        else freeShipping = "khong mien phi";
        Debug.Log($"Bai Tap 15: Gia tri don hang {price} VND - Phi van chuyen: {freeShipping}");
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        int income = Random.Range(1000000, 100000000);
        float tax = 0;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        if (income <= 5000000)
        {
            tax = income * 0.05f;
        }
        else if (income <= 10000000)
        {
            tax = 5000000 * 0.05f + (income - 5000000) * 0.1f;
        }
        else if (income <= 18000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + (income - 10000000) * 0.15f;
        }
        else if (income <= 32000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + (income - 18000000) * 0.2f;
        }
        else if (income <= 52000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + (income - 32000000) * 0.25f;
        }
        else if (income <= 80000000)
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + 20000000 * 0.25f + (income - 52000000) * 0.3f;
        }
        else
        {
            tax = 5000000 * 0.05f + 5000000 * 0.1f + 8000000 * 0.15f + 14000000 * 0.2f + 20000000 * 0.25f + 28000000 * 0.3f + (income - 80000000) * 0.35f;
        }
        Debug.Log($"Bai Tap 16: Voi muc luong: {income} - Thue TNCN: {tax}");
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float scoreA = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 100.0f) * 0.01f;
        float scoreB = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 100.0f) * 0.01f;
        float scoreC = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 100.0f) * 0.01f;
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float avgScore = (scoreA + scoreB + scoreC) / 3;
        string pass = "";
        if (avgScore >= 5.0f)
        {
            pass = "dat yeu cau";
        }
        else pass = "khong dat yeu cau";
        Debug.Log($"Bai Tap 17: Diem mon A: {scoreA} - Diem mon B: {scoreB} - Diem mon C: {scoreC} \n Diem trung binh: {avgScore} - hoc sinh {pass}");
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int currentShipment = Random.Range(1, 200);
        string storage = "";
        if (currentShipment < 100)
        {
            storage = "co kha nang nhap hang";
        }
        else storage = "khong the nhap hang";
        Debug.Log($"Bai Tap 18: so luong hang hien tai: {currentShipment} => {storage}");
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        int number = Random.Range(0, 100);
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if (number == 10)
        {
            Debug.Log($"Bai Tap 19: so {number} = 10");
        }
        else if (number > 10)
        {
            Debug.Log($"Bai Tap 19: so {number} > 10");
        }
        else Debug.Log($"Bai Tap 19: so {number} < 10");
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        float score = (float)Mathf.Round(Random.Range(0.0f, 10.0f) * 100.0f) * 0.01f;
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        string pass = "";
        if (score >= 5.0)
        {
            pass = "du dieu kien";
        }
        else pass = "khong du dieu kien";
        Debug.Log($"Bai Tap 20: Diem thi sinh: {score} => thi sinh {pass} dang ky hoc khoa nang cao");
    }
}
