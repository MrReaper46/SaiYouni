using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        Debug.Log("Bai Tap 1:====================");
        List<Vector3> enemies = new();
        int numberOfEnemies = 5;
        for (int i = 0; i < numberOfEnemies; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = 0;
            float z = Random.Range(-10f, 10f);

            enemies.Add(new Vector3(x, y, z));
        }
        // Vị trí của người chơi được cung cấp
        Vector3 player = new(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        Debug.Log("Player Position: " + player);
        Debug.Log("===============================");
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        float nearest = Mathf.Infinity;
        Vector3 nearestEnemy = new(Mathf.Infinity, 0, Mathf.Infinity);
        foreach (Vector3 enemy in enemies)
        {
            float distance = Vector3.Distance(enemy, player);
            if (distance < nearest)
            {
                nearestEnemy = enemy;
                nearest = distance;
            }

            Debug.Log($"Enemy Position: {enemy} - Distance: {distance}");
        }
        // Trả về thông tin của kẻ địch gần nhất
        Debug.Log("===============================");
        Debug.Log($"Nearest Enemy: {nearestEnemy} - Distance: {nearest}");
        Debug.Log("===============================");
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        Debug.Log("Bai Tap 2: ===========================");
        List<Vector3> items = new();
        int numberOfItems = 5;
        for (int i = 0; i < numberOfItems; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = 0;
            float z = Random.Range(-10f, 10f);

            items.Add(new Vector3(x, y, z));
        }
        // Vị trí của người chơi được cung cấp
        Vector3 player = new(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        Debug.Log("Player Position: " + player);
        Debug.Log("===============================");
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        float nearest = Mathf.Infinity;
        Vector3 nearestItem = new(Mathf.Infinity, 0, Mathf.Infinity);
        foreach (Vector3 item in items)
        {
            float distance = Vector3.Distance(item, player);
            if (distance < nearest)
            {
                nearestItem = item;
                nearest = distance;
            }

            Debug.Log($"Enemy Position: {item} - Distance: {distance}");
        }
        Debug.Log("===============================");
        // Trả về thông tin của vật phẩm gần nhất
        Debug.Log($"Nearest Item: {nearestItem} - Distance: {nearest}");
        Debug.Log("===============================");
    }
}
