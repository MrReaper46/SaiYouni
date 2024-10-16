using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        bool ticketValid = Random.Range(0, 2) == 0;
        string ticket;
        if (ticketValid) ticket = "hop le";
        else ticket = "khong hop le";
        bool isVIP = Random.Range(0, 2) == 0;
        string vip;
        if (isVIP) vip = "la thanh vien VIP";
        else vip = "khong phai la thanh vien VIP";
        bool isInvited = Random.Range(0, 2) == 0;
        string invited;
        if (isInvited) invited = "khach duoc moi";
        else invited = "khong phai khach moi";
        Debug.Log($"Bai Tap 1: Ve: {ticket} - {vip} - {invited}");
        if (ticketValid || isVIP || isInvited) Debug.Log("Nguoi dung du dieu kien vao cua");
        else Debug.Log("Nguoi dung khong du dieu kien vao cua");
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        int firstPrice = Random.Range(10000, 99999);
        int secondPrice = Random.Range(10000, 99999);
        if(secondPrice == firstPrice) secondPrice = Random.Range(10000, 99999);
        int thirdPrice = Random.Range(10000, 99999);
        if (thirdPrice == firstPrice || thirdPrice == secondPrice) thirdPrice = Random.Range(10000, 99999);
        int user = Random.Range(10000, 99999);
        Debug.Log($"Bai Tap 2: Giai 1: {firstPrice} - Giai 2: {secondPrice} - Giai 3: {thirdPrice}");
        if (user == firstPrice || user == secondPrice || user == thirdPrice) Debug.Log($"Ve nguoi dung: {user} - Nguoi dung du dieu kien trung thuong");
        else Debug.Log($"Ve nguoi dung: {user} - Nguoi dung khong du dieu kien trung thuong");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        bool incomeConfirm = Random.Range(0, 2) == 0;
        string income;
        if (incomeConfirm) income = "on dinh";
        else income = "khong on dinh";
        bool propertyConfirm = Random.Range(0, 2) == 0;
        string property;
        if (propertyConfirm) property = "Co tai san the chap";
        else property = "Khong co tai san the chap";
        bool hasGuardian = Random.Range(0, 2) == 0;
        string guardian;
        if (hasGuardian) guardian = "Co nguoi bao lanh";
        else guardian = "Khong co nguoi bao lanh";
        Debug.Log($"Bai Tap 3: Thu nhap: {income} - {property} - {guardian}");
        if (incomeConfirm || propertyConfirm || hasGuardian) Debug.Log("Nguoi dung du dieu kien vay tien");
        else Debug.Log("Nguoi dung khong du dieu kien vay tien");
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        string[] thanhtichArr = { "Xuat sac", "Tot", "Kha", "Trung Binh", "Yeu" };
        int randomIndex1 = Random.Range(0, thanhtichArr.Length);
        int randomIndex2 = Random.Range(0, thanhtichArr.Length);
        string hocTap = thanhtichArr[randomIndex1];
        string ngoaiKhoa = thanhtichArr[randomIndex2];
        bool gdkkConfirm = Random.Range(0, 2) == 0;
        string gdkk;
        if (gdkkConfirm) gdkk = "Co";
        else gdkk = "Khong";
        Debug.Log($"Bai Tap 4: Thanh tich hoc tap: {hocTap} - Hoat dong ngoai khoa: {ngoaiKhoa} - Gia dinh kho khan: {gdkk}");
        if (randomIndex1 == 0 || randomIndex2 <= 1 || gdkkConfirm) Debug.Log("Du dieu kien nhan hoc bong");
        else Debug.Log("Khong du dieu kien nhan hoc bong");
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        bool emailConfirm = Random.Range(0, 2) == 0;
        string email;
        if (emailConfirm) email = "Email hop le";
        else email = "Email khong hop le";
        bool phoneConfirm = Random.Range(0, 2) == 0;
        string phone;
        if (phoneConfirm) phone = "Sdt duoc xac thuc";
        else phone = "Sdt khong duoc xac thuc";
        bool isRegistered = Random.Range(0, 2) == 0;
        string register;
        if (isRegistered) register = "Da dang ki qua trang web";
        else register = "chua dang ki qua trang web";
        Debug.Log($"Bai Tap 5: {email} - {phone} -{register}");
        if (emailConfirm || phoneConfirm || isRegistered) Debug.Log("Du dieu kien nhan dang ki");
        else Debug.Log("Khong du dieu kien dang ki");
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        bool hasLicenced = Random.Range(0, 2) == 0;
        string licence;
        if (hasLicenced) licence = "Co bang lai";
        else licence = "Khong co bang lai";
        bool carRegistered = Random.Range(0, 2) == 0;
        string car;
        if (carRegistered) car = "Xe da duoc dang ki";
        else car = "Xe chua duoc dang ki";
        bool hasInsurance = Random.Range(0, 2) == 0;
        string insurance;
        if (hasInsurance) insurance = "Co bao hiem xe";
        else insurance = "Khong co bao hiem xe";
        Debug.Log($"Bai Tap 6: {licence} - {car} - {insurance}");
        if (hasLicenced || carRegistered || hasInsurance) Debug.Log("Du dieu kien lai xe");
        else Debug.Log("Khong du dieu kien lai xe");
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        bool isAdmin = Random.Range(0, 2) == 0;
        string admin;
        if (isAdmin) admin = "Nguoi dung la quan tri vien";
        else admin = "Nguoi dung khong phai la quan tri vien";
        bool hasPermission = Random.Range(0, 2) == 0;
        string permission;
        if (hasPermission) permission = "Co quyen truy cap";
        else permission = "Khong co quyen truy cap";
        bool hasCode = Random.Range(0, 2) == 0;
        string code;
        if (hasCode) code = "Co ma xac thuc";
        else code = "Khong co co ma xac thuc";
        Debug.Log($"Bai Tap 7: {admin} - {permission} - {code}");
        if (isAdmin || hasPermission || hasCode) Debug.Log("Co quyen truy cap tai lieu");
        else Debug.Log("Khong co quyen truy cap tai lieu");
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        bool hasRecommendation = Random.Range(0, 2) == 0;
        string recommendation;
        if (hasRecommendation) recommendation = "Nguoi dung co thu gioi thieu tu giao vien";
        else recommendation = "Nguoi dung khong co thu gioi thieu tu giao vien";
        bool completeTest = Random.Range(0, 2) == 0;
        string test;
        if (completeTest) test = "Da hoan thanh bai kiem tra";
        else test = "Chua hoan thanh bai kiem tra";
        bool hasExp = Random.Range(0, 2) == 0;
        string exp;
        if (hasExp) exp = "Co kinh nghiem";
        else exp = "Khong co kinh nghiem";
        Debug.Log($"Bai Tap 8: {recommendation} - {test} - {exp}");
        if (hasRecommendation || completeTest || hasExp) Debug.Log("Du dieu kien tham gia khoa hoc");
        else Debug.Log("Khong du dieu kien tham gia khoa hoc");
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        bool hasPromotion = Random.Range(0, 2) == 0;
        string promotion;
        if (hasPromotion) promotion = "Nguoi dung co ma khuyen mai";
        else promotion = "Nguoi dung khong co ma khuyen mai";
        bool isVIP = Random.Range(0, 2) == 0;
        string vip;
        if (isVIP) vip = "La thanh vien VIP";
        else vip = "Khong phai la thanh vien VIP";
        bool hasTrial = Random.Range(0, 2) == 0;
        string trail;
        if (hasTrial) trail = "dang dung mien phi";
        else trail = "khong duoc dung mien phi";
        Debug.Log($"Bai Tap 9: {promotion} - {vip} - {trail}");
        if (hasPromotion || isVIP || hasTrial) Debug.Log("Du dieu kien tai ung dung mien phi");
        else Debug.Log("Khong du dieu kien tai ung dung mien phi");
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        bool spendingValid = Random.Range(0, 2) == 0;
        string spending;
        if (spendingValid) spending = "Chi tieu tren muc yeu cau";
        else spending = "Chi tieu duoi muc yeu cau";
        bool isRegular = Random.Range(0, 2) == 0;
        string regular;
        if (isRegular) regular = "La khach hang than thiet";
        else regular = "Khong phai la khach hang than thiet";
        bool hasPromotion = Random.Range(0, 2) == 0;
        string promotion;
        if (hasPromotion) promotion = "co khuyen mai";
        else promotion = "khong co khuyen mai";
        Debug.Log($"Bai Tap 10: {spending} - {regular} - {promotion}");
        if (spendingValid || isRegular || hasPromotion) Debug.Log("Du dieu kien su dung dich vu dac biet");
        else Debug.Log("Khong du dieu kien su dung dich vu dac biet");
    }
}
