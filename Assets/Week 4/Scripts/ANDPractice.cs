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
        float avgScore = Random.Range(0.0f, 10.00001f);
        float extraScore = Random.Range(0.0f, 10.00001f);
        bool violation = Random.Range(0, 2) == 0;
        string kiluat;
        if (violation == true)
        {
            kiluat = "co";
        }
        else kiluat = "khong";
        Debug.Log($"Bai Tap 3: Diem TB: {avgScore} - Diem ngoai khoa: {extraScore} - Vi pham ky luat: {kiluat}");
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (avgScore >= 9.0f && extraScore >= 8.0f && violation != true) Debug.Log("SV du dieu kien nhan hoc bong");
        else Debug.Log("SV khong du dieu kien nhan hoc bong");
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        bool emailConfirm = Random.Range(0, 2) == 0;
        string email;
        if (emailConfirm == true) email = "hop le";
        else email = "khong hop le";
        bool phoneConfirm = Random.Range(0, 2) == 0;
        string phone;
        if (phoneConfirm == true) phone = "hop le";
        else phone = "khong hop le";
        bool feeConfirm = Random.Range(0, 2) == 0;
        string fee;
        if (feeConfirm == true) fee = "da thanh toan";
        else fee = "chua thanh toan";
        Debug.Log($"Bai Tap 4: Email: {email} - So dien thoai: {phone} - Phi tham gia: {fee}");
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if(emailConfirm == true&&phoneConfirm == true&& feeConfirm == true) Debug.Log("Dang ki hop le");
        else Debug.Log("Dang ki khong hop le");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        float score = Random.Range(0.0f, 10.00001f);
        int failedClass = Random.Range(0, 5);
        float presentScore = Random.Range(0.0f, 100.00001f);
        Debug.Log($"Bai Tap 5: Diem tong ket: {score} - So mon truot: {failedClass} - Diem chuyen can: {presentScore}%");
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        if (score < 5.0f && failedClass <= 2 && presentScore > 75) Debug.Log("Du dieu kien thi lai");
        else Debug.Log("Khong du dieu kien thi lai");
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        bool isGraduated = Random.Range(0, 2) == 0;
        string totNghiep;
        if (isGraduated == true) totNghiep = "Da tot nghiep";
        else totNghiep = "Chua tot nghiep";
        int yearsOfExp = Random.Range(0, 50);
        bool isTested = Random.Range(0, 2) == 0;
        string kTNL;
        if (isTested == true) kTNL = "dau";
        else kTNL = "khong dau";
        Debug.Log($"Bai Tap 6: Hoc van DH: {totNghiep} - Kinh nghiem: {yearsOfExp} nam - Bai KTra NL: {kTNL}");
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        if (isGraduated && yearsOfExp >= 2 && isTested) Debug.Log("Nhan vien du nang luc");
        else Debug.Log("Nhan vien chua du nang luc");
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        bool moneySufficient = Random.Range(0, 2) == 0;
        string tien;
        if (moneySufficient == true) tien = "Du tien";
        else tien = "Khong du tien";
        bool isSupplied = Random.Range(0, 2) == 0;
        string supplied;
        if (isSupplied == true) supplied = "co";
        else supplied = "Khong";
        bool promotionApproved = Random.Range(0, 2) == 0;
        string kM;
        if (promotionApproved == true) kM = "Du dieu kien";
        else kM = "Khong du dieu kien";
        Debug.Log($"Bai Tap 7: So du: {tien} -  Hang trong kho: {supplied} - Dieu kien tham gia KM: {kM}");
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        if (moneySufficient && isSupplied && promotionApproved) Debug.Log("KH du dieu kien tham gia KM");
        else Debug.Log("KH khong du dieu kien tham gia KM");
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        int mission = Random.Range(0, 50);
        float score = Random.Range(0.0f, 10.00001f);
        bool loggedIn = Random.Range(0, 2) == 0;
        string dN;
        if (loggedIn == true) dN = "Co";
        else dN = "Khong";
        Debug.Log($"Bai Tap 8: So NV hoan thanh: {mission} - Diem NV: {score} - Da dang nhap:  {dN}");
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        if (mission >= 10 && score >= 8.00f && loggedIn) Debug.Log("Du DK nhan Thuong");
        else Debug.Log("Khong du DK nhan Thuong");
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        int yearOfWorking = Random.Range(0, 50);
        bool isPassed = Random.Range(0, 2) == 0;
        string passed;
        if (isPassed == true) passed = "Dat chi tieu";
        else passed = "Khong dat chi tieu";
        bool violation = Random.Range(0, 2) == 0;
        string kiluat;
        if (violation == true) kiluat = "co";
        else kiluat = "khong";
        Debug.Log($"Bai Tap 9: So Nam lam viec: {yearOfWorking} - Dat chi tieu cong viec: {passed} - Vi pham ki luat: {kiluat}");
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        if (yearOfWorking >= 5 && isPassed && !violation) Debug.Log("Du dieu kien thang chuc");
        else Debug.Log("Khong du dieu kien thang chuc");
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        int age = Random.Range(0, 100);
        bool isVIP = Random.Range(0, 2) == 0;
        string vip;
        if (isVIP == true) vip = "da la thanh vien";
        else vip = "chua la thanh vien";
        int year = Random.Range(0, age);
        Debug.Log($"Bai Tap 10: Tuoi: {age} - VIP: {vip} - So nam: {year}");
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        if (age >= 60 && isVIP && year >= 3) Debug.Log("Du dieu kien nhan ve mien phi");
        else Debug.Log("Khong du dieu kien nhan ve mien phi");
    }
}
