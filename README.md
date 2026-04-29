# 🎮 2D Top-Down Shooter (Unity)

> A polished 2D top-down action game built with Unity, focusing on smooth gameplay, scalable architecture, and modern rendering techniques.

<p align="center">
  <img src="docs/demo.gif" width="600"/>
</p>

---

## 🚀 Overview

This project is a **top-down shooter prototype** designed to demonstrate:

* Clean and maintainable **Unity architecture**
* Smooth and responsive **player movement system**
* Advanced **camera control using Cinemachine**
* Flexible and reusable **game systems**

---

## ✨ Key Features

### 🎮 Gameplay

* 8-direction movement with smooth input handling
* Dash mechanic with cooldown
* Weapon switching system
* Real-time combat interactions

### 🎥 Camera System

* Cinemachine-based smooth follow
* Camera boundaries using Confiner
* Dynamic tracking for better player experience

### 🎨 Graphics & Effects

* Custom shaders using ShaderLab & HLSL
* Optimized 2D rendering pipeline
* Pixel-art friendly workflow

### 🧠 Architecture

* Modular and scalable code structure
* ScriptableObject-driven configuration
* Separation of concerns (Gameplay / Systems / Data)

---

## 🧩 Tech Stack

| Category  | Technology       |
| --------- | ---------------- |
| Engine    | Unity 2022.3 LTS |
| Language  | C#               |
| Camera    | Cinemachine      |
| Rendering | ShaderLab / HLSL |
| UI        | TextMesh Pro     |

---

## 🎯 Controls

| Input         | Action         |
| ------------- | -------------- |
| W / A / S / D | Move           |
| Mouse Left    | Attack         |
| Space         | Dash           |
| 1 → 5         | Switch weapons |

---

## 📁 Project Architecture

```bash
2D_TopDown
├── Assets
│   ├── Animations
│   ├── Materials
│   ├── Prefabs
│   ├── Scenes
│   ├── ScriptableObjects
│   ├── Scripts
│   │   ├── Core        # Game loop, managers
│   │   ├── Player      # Player logic
│   │   ├── Enemy       # Enemy AI
│   │   ├── Combat      # Attack, damage system
│   │   └── Systems     # Camera, Input, UI
│   ├── Sprites
│   └── Tilemap
├── Packages
└── ProjectSettings
```

---

## ⚙️ Getting Started

### 1. Clone Repository

```bash
git clone https://github.com/Tunaanhgamedev/2D_TopDown.git
```

### 2. Open in Unity

* Open Unity Hub
* Click **Add project from disk**
* Select the cloned folder

### 3. Run

* Open `Main Scene`
* Click **Play**

---

## 🧪 Development Highlights

### ✔ Clean Code Practices

* Organized folder structure
* Reusable components
* Decoupled systems

### ✔ Performance Considerations

* Optimized sprite rendering
* Lightweight systems design

### ✔ Scalability

* Easy to add new weapons, enemies, or mechanics
* Designed for future expansion

---

## 📸 Screenshots

<p align="center">
  <img src="docs/screenshot1.png" width="400"/>
  <img src="docs/screenshot2.png" width="400"/>
</p>

---

## 🎥 Demo Video

> Add your gameplay video here (YouTube recommended)

---

## 🛣️ Roadmap

* [ ] Enemy AI behaviors (patrol, chase, attack)
* [ ] Health & damage system
* [ ] UI system (HUD, menu)
* [ ] Sound & VFX polish
* [ ] Mobile support

---

## 🤝 Contributing

Contributions are welcome!

```bash
# Fork → Create branch → Commit → Pull Request
```

---

## 📜 License

MIT License (recommended)

---

## 👨‍💻 Author

**Tunaanhgamedev**

---

## ⭐ Support

If you like this project, give it a ⭐ on GitHub — it really helps!
