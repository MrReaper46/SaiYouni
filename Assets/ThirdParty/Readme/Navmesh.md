# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.
Trong Unity, NavMeshObstacle là một thành phần dùng để tạo ra các vật cản trong bản đồ điều hướng (NavMesh), nhằm ngăn chặn các đối tượng có khả năng điều hướng (NavMesh Agent) đi qua hoặc tương tác với các khu vực nhất định. Đây là một công cụ hữu ích khi xây dựng các chướng ngại vật hoặc vật thể di chuyển trong môi trường game. Dưới đây là hướng dẫn sử dụng NavMeshObstacle:

1. Thêm NavMesh Obstacle vào GameObject
Chọn GameObject mà bạn muốn tạo thành chướng ngại vật.
Trong cửa sổ Inspector, nhấn Add Component.
Tìm và chọn NavMeshObstacle.
2. Cấu hình NavMesh Obstacle
Sau khi thêm thành phần này vào GameObject, bạn sẽ thấy các tùy chọn sau trong cửa sổ Inspector:

Shape (Hình dạng): Có hai loại hình dạng là Box và Capsule. Chọn hình dạng phù hợp nhất với chướng ngại vật của bạn.
Box: Là hình hộp chữ nhật, thích hợp cho các vật thể hình hộp.
Capsule: Là hình con nhộng, thường dùng cho các vật thể hình tròn hoặc trụ.
Carving: Tích vào tùy chọn này nếu bạn muốn đối tượng cản trở NavMesh một cách động. Khi Carving được bật, NavMesh sẽ được cập nhật tự động khi chướng ngại vật di chuyển, tạo khoảng trống trên NavMesh để các Agent tránh.
Carving Move Threshold: Xác định khoảng cách tối thiểu mà chướng ngại vật phải di chuyển để cập nhật NavMesh. Nếu chướng ngại vật di chuyển ít hơn giá trị này, NavMesh sẽ không cập nhật.
Carving Time To Stationary: Định rõ thời gian mà đối tượng phải đứng yên trước khi NavMesh được cập nhật để làm cho chướng ngại vật có hiệu lực.
3. Sử dụng NavMesh Obstacle trong Game
Khi bạn chạy game, nếu NavMesh Agent gặp phải một NavMeshObstacle, nó sẽ tự động điều hướng để tránh chướng ngại vật.
Nếu Carving được bật, NavMesh Agent sẽ tự động cập nhật đường đi khi chướng ngại vật di chuyển, phù hợp cho các chướng ngại động hoặc các vật thể có khả năng dịch chuyển.
4. Kết hợp với NavMesh Agent
