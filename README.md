# 🎮 2D Top-Down Action Framework (Unity)

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%20LTS-blue.svg?style=flat-square&logo=unity)](https://unity.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green.svg?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Web-orange.svg?style=flat-square)](https://unity.com/)
[![License](https://img.shields.io/badge/License-MIT-lightgrey.svg?style=flat-square)](LICENSE)

> Một bộ mã nguồn (framework) hoàn chỉnh cho trò chơi hành động 2D góc nhìn từ trên xuống (Top-Down), được xây dựng với kiến trúc module hóa, dễ dàng mở rộng và tối ưu hiệu suất.

---

## 📖 Giới thiệu

Dự án này là một bản thử nghiệm (prototype) cao cấp cho thể loại **Top-Down Shooter/Slasher**, tập trung vào việc triển khai các hệ thống cốt lõi bền vững:
* **Kiến trúc sạch (Clean Architecture):** Sử dụng Singleton Pattern và ScriptableObjects để quản lý dữ liệu.
* **Hệ thống điều khiển hiện đại:** Tích hợp Unity Input System mới nhất.
* **Trí tuệ nhân tạo (AI):** Hệ thống tìm đường thông minh và trạng thái chiến đấu linh hoạt.

---

## ✨ Các Tính Năng Nổi Bật

### 🛡️ Hệ Thống Người Chơi (Player System)
* **Movement:** Di chuyển 8 hướng mượt mà, cơ chế lướt (Dash) tiêu tốn thể lực (Stamina).
* **Combat:** Hệ thống vũ khí linh hoạt (Melee/Ranged) thông qua `IWeapon` interface.
* **VFX:** Hiệu ứng Trail Renderer khi lướt và Flash hiệu ứng khi nhận sát thương.
* **Stats:** Quản lý Máu (Health) và Thể lực (Stamina) với cơ chế tự hồi phục.

### 🧠 Trí Tuệ Nhân Tạo (AI & Navigation)
* **Pathfinding:** Tích hợp **A* Pathfinding Project** giúp kẻ địch vượt địa hình phức tạp.
* **State Machine:** Kẻ địch có các trạng thái: *Roaming* (Tuần tra), *Chasing* (Đuổi theo), và *Attacking* (Tấn công).
* **Diversity:** Hỗ trợ nhiều loại kẻ địch khác nhau (ví dụ: Grape - kẻ địch tấn công tầm xa).

### ⚙️ Hệ Thống Quản Lý (Core Management)
* **Scene Management:** Chuyển cảnh mượt mà với hiệu ứng Fade-in/out.
* **Singleton Framework:** Đảm bảo tính duy nhất và dễ dàng truy cập cho các Manager (GameManager, Inventory, UI).
* **Cinemachine:** Camera theo dõi thông minh, rung màn hình (Screen Shake) và giới hạn khung hình (Confiner).

---

## 🛠️ Công Nghệ Sử Dụng

| Thành phần | Công nghệ | Chi tiết |
| :--- | :--- | :--- |
| **Engine** | Unity 2022.3.x | Long Term Support (LTS) |
| **Rendering** | Universal Render Pipeline (URP) | Tối ưu hóa cho 2D Light & Shadows |
| **Input** | Input System Package | Hỗ trợ đa thiết bị (Keyboard/Gamepad) |
| **Animation** | 2D Animation & Sprite Editor | Skeletal Animation & Frame-based |
| **Navigation** | A* Pathfinding Project | Xử lý đường đi chuyên nghiệp |
| **UI** | TextMesh Pro | Hiển thị văn bản sắc nét |

---

## 📁 Cấu Trúc Thư Mục

```text
Assets/
├── Animations/       # Controllers và clips cho Player & Enemies
├── Materials/        # Vật liệu cho Sprite và hiệu ứng đặc biệt
├── Prefabs/          # Các đối tượng tái sử dụng (Player, Weapons, Props)
├── Scenes/           # Các màn chơi chính và màn chơi thử nghiệm
├── ScriptableObjs/   # Dữ liệu cấu hình vũ khí, máu, sát thương
├── Scripts/          # Toàn bộ logic C# (Phân chia theo Module)
│   ├── Enemies/      # Logic AI và hành vi kẻ địch
│   ├── Management/   # Managers, Singleton, Scene Control
│   ├── Player/       # Controller, Health, Stamina, Combat
│   └── UI/           # Logic giao diện người dùng
├── Sprites/          # Tài nguyên hình ảnh (Pixel Art)
└── Tilemap/          # Tileset và dữ liệu bản đồ
```

---

## 🚀 Hướng Dẫn Cài Đặt

1. **Clone project:**
   ```bash
   git clone https://github.com/Tunaanhgamedev/2D_TopDown.git
   ```
2. **Mở bằng Unity Hub:**
   * Sử dụng phiên bản **Unity 2022.3 LTS**.
   * Đảm bảo các packages như `Input System`, `Cinemachine`, `A* Pathfinding` đã được cài đặt tự động qua Package Manager.
3. **Chạy thử:**
   * Mở scene `Main Scene` trong thư mục `Assets/Scenes`.
   * Nhấn **Play** để bắt đầu.

---

## 🎮 Điều Khiển (Default Controls)

* **W/A/S/D:** Di chuyển nhân vật.
* **Chuột trái:** Tấn công (Chém/Bắn).
* **Space:** Lướt (Dash).
* **Phím 1 - 5:** Thay đổi vũ khí nhanh.
* **Esc:** Tạm dừng (Pause).

---

## 🗺️ Lộ Trình Phát Triển (Roadmap)

- [x] Hệ thống di chuyển và chiến đấu cơ bản.
- [x] AI kẻ địch và hệ thống tìm đường.
- [x] Hệ thống Inventory và thay đổi vũ khí.
- [ ] Triển khai hệ thống Lưu/Tải (Save/Load system).
- [ ] Thêm các loại Boss với kỹ năng đặc biệt.
- [ ] Tối ưu hóa hiệu ứng âm thanh (SFX & BGM).
- [ ] Hệ thống nhiệm vụ (Quest System).

---

## 👨‍💻 Tác Giả

**Tunaanhgamedev**
* GitHub: [@Tunaanhgamedev](https://github.com/Tunaanhgamedev)
* Email: [liên hệ của bạn]

---

## 📜 Giấy Phép (License)

Dự án này được phát hành dưới giấy phép **MIT**. Bạn có thể tự do sử dụng và phát triển thêm.

---

Nếu bạn thấy dự án này hữu ích, đừng quên tặng nó một ⭐ trên GitHub nhé!
