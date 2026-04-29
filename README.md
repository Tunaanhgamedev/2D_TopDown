#2D_TopDown
#Dự án trò chơi 2D từ trên xuống 🎮

![Unity](https://img.shields.io/badge/Unity-2022.3%20LTS-black?style=flat-square&logo=unity)
![C#](https://img.shields.io/badge/C%23-Programming-blue?style=flat-square&logo=c-sharp)

## 📖 Giới thiệu
**2D Top-Down** là trò chơi nhập vai từ trên xuống được phát triển với **Unity 2022.3**.   Trò chơi có phong cách đồ họa Pixel Art cổ điển, kết hợp với cơ chế điều khiển mượt mà và hệ thống lưu trữ dữ liệu đám mây hiện đại.   Dự án này được xây dựng với mục tiêu tạo ra một khuôn khổ vững chắc cho trò chơi 2D với các yếu tố quản lý tài khoản người chơi.

## 🚀 Tính năng nổi bật

### 🎮 Lối chơi & Đồ họa
* **Hệ thống điều khiển từ trên xuống:** Di chuyển linh hoạt theo 8 hướng cùng hệ thống xử lý va chạm chính xác.
* **Camera Tracking (Cinemachine):** Hệ thống camera thông minh bám sát nhân vật, xử lý mượt mà các góc quay và giới hạn màn hình (Confiner).
* **Trình tạo bóng tùy chỉnh:** Tích hợp ShaderLab và HLSL để tạo hiệu ứng hình ảnh độc đáo và tối ưu hóa hiệu suất kết xuất 2D.

## 📂 Cấu trúc thư mục chính
```văn bản
📦 2D_TopDown
 ┣ 📂 Tài sản
 ┃ ┣ 📂 Ảnh động # Tệp Bộ điều khiển Hoạt hình & Hoạt hình
 ┃ ┣ 📂 Prefabs # Đối tượng đóng gói (Người chơi, Kẻ thù, Môi trường...)
 ┃ ┣ 📂 Cảnh # Chứa Cảnh chính, Cảnh đăng nhập...
 ┃ ┣ 📂 Scripts # C# xử lý mã nguồn logic trò chơi, Firebase Auth, Cơ sở dữ liệu
 ┃ ┣ 📂 Shader # Chứa file ShaderLab & HLSL
 ┃ ┗ 📂 Tài nguyên hình ảnh Sprites # Pixel Art
 ┣ 📂 Gói # Quản lý gói Unity (Cinemachine, 2D Tools...)
 ┗ 📂 ProjectSettings # Cấu hình dự án Unity#2D_TopDown

## ⌨️ Điều khiển tắt (Controls)
* **W / A / S / D : Di chuyển nhân vật.
* **Chuột trái: Tấn công.
* **Phím Space: Dash.
* **Phím số: 1 / 2 / 3 / 4 / 5: Thay đổi vũ khí hoặc đổi sang tay bình thường.

## ⚙️ Hướng dẫn Cài đặt & Triển khai
### Yêu cầu hệ thống
* **Unity Editor: Phiên bản 2022.3 LTS (Bắt buộc để tránh lỗi tương thích).
* **Hệ điều hành: Windows / macOS.

### Các bước cài đặt
* **Clone dự án: git clone [https://github.com/Tunaanhgamedev/2D_TopDown.git](https://github.com/Tunaanhgamedev/2D_TopDown.git)
* **Mở dự án: Khởi động Unity Hub -> Add project from disk -> Chọn thư mục dự án.
* **Trải nghiệm: Mở Scene đăng nhập hoặc Main Scene trong thư mục Assets/Scenes và nhấn nút Play.

## 🤝 Đóng góp (Contributing)
* **Mọi đóng góp, báo lỗi (Issues) hay yêu cầu tính năng (Pull Requests) đều được chào đón để giúp dự án hoàn thiện hơn. Vui lòng tạo Issue để thảo luận trước khi tạo Pull Request lớn.

## 📄 Giấy phép (License)

#Phát triển bởi Tunaanhgamedev ☕
