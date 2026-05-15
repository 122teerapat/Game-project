# Game Project - Worms-Style Turn-Based Shooter

A fun and engaging 2D turn-based shooter game built with **Unity 2022.3.10f1** in **C#**. Control characters, aim guns, charge shots, and battle opponents in strategic turn-based combat!

## 📋 Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Quick Start](#quick-start)
- [How to Play](#how-to-play)
- [Project Structure](#project-structure)
- [Game Systems](#game-systems)
- [Controls](#controls)
- [Visual Features](#visual-features)
- [Prefabs](#prefabs)
- [Troubleshooting](#troubleshooting)
- [Roadmap](#roadmap)
- [Credits](#credits)

---

## ✨ Features

| Feature | Details |
|---------|---------|
| **Turn-Based Combat** | Players alternate taking strategic shots |
| **Charge Mechanics** | Hold to power up shots (5-20 force range) |
| **Physics Bullets** | Realistic gravity and projectile trajectory |
| **Multiple Players** | Support for 2+ players in single match |
| **Wind Effects** | Dynamic wind affects bullet direction |
| **Health System** | Track damage and eliminate players |
| **Destructible Ground** | Terrain takes damage from impacts |

---

## 🛠️ Tech Stack

| Component | Technology |
|-----------|-----------|
| **Engine** | Unity 2022.3.10f1 |
| **Language** | C# |
| **Physics** | Rigidbody2D (2D Physics) |
| **Camera** | Cinemachine Virtual Camera |
| **UI** | Canvas, TextMesh Pro |

---

## 🚀 Quick Start

### Prerequisites
- Unity Hub installed
- Unity 2022.3.10f1 installed
- Git installed

### Installation

```bash
# Clone the repository
git clone https://github.com/122teerapat/Game-project.git
cd Game-project

# Open in Unity Hub
# Select the project folder
# Unity will load version 2022.3.10f1 automatically

# Press Play button to start
```

---

## 🎮 How to Play

### Movement
- **A Key** - Move left
- **D Key** - Move right
- **Space** - Jump

### Aiming & Shooting
- **Move Mouse** - Rotate gun to aim
- **Hold Left Click** - Charge shot (watch the charge bar)
- **Release Left Click** - Fire projectile
- Longer hold = more power!

### Win Condition
- **Be the last player standing**
- Eliminate all opponents through strategic shooting

---

## 🎯 Game Flow

1. Players spawn on opposite sides of arena
2. **Player 1** charges and fires
3. Camera switches to **Player 2**
4. **Player 2** charges and fires
5. Process repeats until one player remains
6. **Winner declared! 🎉**

---

## 📂 Project Structure

```
Game-project/
├── Assets/
│   ├── Scripts/              # 13 C# game scripts
│   ├── Scenes/
│   │   ├── MainMenu.unity   # Menu scene
│   │   └── GameScene.unity  # Gameplay scene
│   ├── Prefab/              # Reusable objects
│   ├── Animation/           # Character animations
│   ├── Sprites/             # 2D sprite assets
│   └── backgrond/           # Background images
├── ProjectSettings/         # Unity configuration
└── README.md
```

---

## ⚙️ Game Systems

### 13 Core Scripts

| Script | Purpose |
|--------|---------|
| `playController.cs` | Player movement & control |
| `Gun.cs` | Weapon system & charging |
| `bullet.cs` | Projectile physics & behavior |
| `playerHealth.cs` | Health tracking & damage |
| `turnController.cs` | Turn management & switching |
| `HealthBar.cs` | UI health display |
| `chargeBar.cs` | Charge indicator UI |
| `Wind.cs` | Wind effect mechanics |
| `cameraZoom.cs` | Camera following player |
| `Ground.cs` | Terrain & environment |
| `Booom.cs` | Explosion effects |
| `MainMenu.cs` | Menu interactions |
| `Controller.cs` | Game manager |

---

## 🎮 Controls Summary

### Keyboard
| Input | Action |
|-------|--------|
| **A** | Move Left |
| **D** | Move Right |
| **Space** | Jump |
| **Mouse Move** | Aim Gun |
| **Left Click (Hold)** | Charge Shot |
| **Left Click (Release)** | Fire |
| **Scroll** | Zoom In/Out |

---

## 🎨 Visual Features

✅ **Sprite Animations** - Walk, jump, idle animations  
✅ **Particle Effects** - Explosions and impact effects  
✅ **Health Bars** - Real-time UI health display  
✅ **Charge Indicator** - Visual charge progress bar  
✅ **Parallax Background** - Layered scrolling background  
✅ **Dynamic Camera** - Smooth following of active player  

---

## 📦 Included Prefabs

### Projectiles
- Regular bullets
- Missiles (larger, more damage)
- Grenades (explosive)
- Explosion bullets (variants)

### Effects
- Explosion effects (3 variants)
- Impact effects
- Boom/damage effects

### Environment
- Ground/terrain platforms
- Circular obstacles

---

## 🐛 Troubleshooting

| Issue | Solution |
|-------|----------|
| **Unity won't open project** | Install Unity 2022.3.10f1 |
| **Missing assets** | Delete `Library` folder and reimport |
| **Player can't move** | Verify `playController.cs` on player |
| **Camera not following** | Check Cinemachine camera is configured |
| **Physics broken** | Verify Rigidbody2D settings are correct |

---

## 🎯 Roadmap

### Planned Features
- [ ] AI opponents for single-player
- [ ] Multiple game modes (Classic, Survival, Team Battle)
- [ ] Sound effects & background music
- [ ] Mobile touch controls
- [ ] Leaderboard system
- [ ] Additional weapon types
- [ ] Power-ups & special items
- [ ] Network multiplayer support
- [ ] Weather effects (rain, snow)
- [ ] Level editor

---

## 📊 What You Get

✅ **Complete turn-based shooter game**  
✅ **13 well-organized C# scripts**  
✅ **Physics-based gameplay mechanics**  
✅ **Multiple player support**  
✅ **Production-ready code**  
✅ **Ready to play and extend**  

---

## 🎓 Perfect For

- Learning Unity game development
- Understanding multiplayer mechanics
- Physics system implementation
- UI and Canvas management
- Turn-based game design patterns
- C# scripting in game dev

---

## 📄 License

This project is open source and available under the MIT License.

---

## 👤 Author

**Teerapat** (122teerapat)  
GitHub: [122teerapat](https://github.com/122teerapat)  
Repository: [Game-project](https://github.com/122teerapat/Game-project)

---

## 🎮 Version Info

- **Game Version**: 1.0.0
- **Unity Version**: 2022.3.10f1
- **Language**: C#
- **Status**: Active Development

---

## 🙏 Acknowledgments

- Unity Technologies for the amazing engine
- Cinemachine team for camera system
- Community for feedback and support

---

**Have fun playing and creating! 🎮🎯**

For issues, bugs, or feature requests, please open an issue on the GitHub repository.

---

*Made with ❤️ using Unity*
