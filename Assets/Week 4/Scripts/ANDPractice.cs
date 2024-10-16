using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        int age = Random.Range(0, 100);
        bool hasLicenced;
        if (age < 18) hasLicenced = false;
        hasLicenced = Random.Range(0, 2) == 0;
        string Licence;
        if (hasLicenced == true)
        {
            Licence = "co";
        }
        else Licence = "khong";
        int experience;
        if (age <= 18) experience = 0;
        experience = Random.Range(0, age - 18);
        Debug.Log($"Bai Tap 1: Tuoi: {age} - GPLX: {Licence} - So nam kn: {experience}");
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        if (age >= 18 && hasLicenced == true && experience >= 1) Debug.Log("Nguoi dung du dieu kien");
        else Debug.Log("Nguoi dung khong du dieu kien");
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        bool hasTicket = Random.Range(0, 2) == 0;
        string ve;
        if (hasTicket == true)
        {
            ve = "co";
        }
        else ve = "khong";
        bool isRegistered = Random.Range(0, 2) == 0;
        string dk;
        if (isRegistered == true)
        {
            dk = "co";
        }
        else dk = "khong";
        bool hasCVD = Random.Range(0, 2) == 0;
        string benhtim;
        if (hasCVD == true)
        {
            benhtim = "co";
        }
        else benhtim = "khong";
        Debug.Log($"Bai Tap 2: Tinh trang ve: {ve} - Da dang ki: {dk} - benh tim: {benhtim}");
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        if (hasTicket == true && isRegistered == true && hasCVD != true) Debug.Log("Nguoi dung du dieu kien");
        else Debug.Log("Nguoi dung khong du dieu kien");
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        float avgscore = Random.Range(0.0f, 10.00001f);
        float extrascore = Random.Range(0.0f, 10.00001f);
        bool violation = Random.Range(0, 2) == 0;
        string kiluat;
        if (violation == true)
        {
            kiluat = "co";
        }
        else kiluat = "khong";
        Debug.Log($"Bai Tap 3: Diem TB: {avgscore} - Diem ngoai khoa: {extrascore} - Vi pham ky luat: {kiluat}");
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (avgscore >= 9.0f && extrascore >= 8.0f && violation != true) Debug.Log("SV du dieu kien nhan hoc bong");
        else Debug.Log("SV khong du dieu kien nhan hoc bong");
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        bool emailconfirm = Random.Range(0, 2) == 0;
        string email;
        if (emailconfirm == true) email = "hop le";
        else email = "khong hop le";
        bool phoneconfirm = Random.Range(0, 2) == 0;
        string phone;
        if (phoneconfirm == true) phone = "hop le";
        else phone = "khong hop le";
        bool feeconfirm = Random.Range(0, 2) == 0;
        string fee;
        if (feeconfirm == true) fee = "da thanh toan";
        else fee = "chua thanh toan";
        Debug.Log($"Bai Tap 4: Email: {email} - So dien thoai: {phone} - Phi tham gia: {fee}");
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if(emailconfirm == true&&phoneconfirm == true&& feeconfirm == true) Debug.Log("Dang ki hop le");
        else Debug.Log("Dang ki khong hop le");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
    }
}
