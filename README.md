# Game Project - Worms-Style Turn-Based Shooter

A fun and engaging 2D turn-based shooter game built with Unity. Players control characters equipped with guns and take turns shooting at opponents. The game features realistic physics, charge mechanics, and explosive effects inspired by the classic Worms game series.

## 📋 Table of Contents

- [Features](#features)
- [Game Overview](#game-overview)
- [Tech Stack](#tech-stack)
- [System Requirements](#system-requirements)
- [Project Structure](#project-structure)
- [Installation & Setup](#installation--setup)
- [How to Play](#how-to-play)
- [Game Mechanics](#game-mechanics)
- [Controls](#controls)
- [Game Systems](#game-systems)
- [Prefabs & Objects](#prefabs--objects)
- [Scripts Overview](#scripts-overview)
- [Scenes](#scenes)
- [Graphics & Audio](#graphics--audio)
- [Development](#development)
- [Credits](#credits)
- [License](#license)

---

## ✨ Features

### Core Gameplay
- **Turn-Based Combat**: Strategic gameplay where players take turns shooting
- **Charge Mechanics**: Hold to charge shots for increased power and range
- **Physics-Based Bullets**: Realistic projectile physics with gravity
- **Multiple Players**: Support for 2+ players in single match
- **Health System**: Each player has health that decreases with damage
- **Destructible Environment**: Ground can be damaged and destroyed

### Weapons & Items
- **Charged Gun**: Primary weapon with variable power levels
- **Bullet Types**: Regular bullets, grenades, and missiles
- **Explosive Effects**: Multiple explosion types with visual effects
- **Wind Effects**: Dynamic wind affects bullet trajectory
- **Trajectory Prediction**: Visual feedback for aiming

### Visuals & Polish
- **Sprite-Based Animation**: Smooth character animations
- **Particle Effects**: Explosion and impact effects
- **Dynamic Camera**: Cinemachine virtual camera follows active player
- **UI System**: Health bars, charge indicators, turn display
- **Main Menu**: Interactive menu for starting games
- **Atmospheric Background**: Parallax scrolling backgrounds

### Game Features
- **Main Menu Scene**: Game initialization and navigation
- **Gameplay Scene**: Full multiplayer battle arena
- **Health Tracking**: Real-time player health display
- **Turn Management**: Automatic turn switching between players
- **Score System**: Track player statistics

---

## 🎮 Game Overview

The game simulates a classic turn-based shooter experience where:

1. **Setup Phase**: Players are positioned on the game arena
2. **Turn System**: Players take turns controlling their character
3. **Aiming Phase**: Players aim their gun using the mouse
4. **Charging Phase**: Hold down to charge for more power
5. **Shooting Phase**: Release to fire the projectile
6. **Impact Phase**: Bullets travel and explode on impact
7. **Damage Phase**: Opposing players take damage
8. **Victory Condition**: Last player standing wins

---

## 🛠️ Tech Stack

| Component | Technology |
|-----------|-----------|
| **Engine** | Unity 2022.3.10f1 |
| **Language** | C# |
| **Physics** | Rigidbody2D (2D Physics) |
| **Graphics** | Sprites, Particle Systems |
| **Camera** | Cinemachine Virtual Camera |
| **UI** | Canvas, TextMesh Pro |
| **Input** | Legacy Input Manager |

---

## 💻 System Requirements

### Minimum Requirements
- **OS**: Windows 10, macOS 10.13, Linux (Ubuntu 16.04+)
- **RAM**: 4 GB
- **Storage**: 2 GB free space
- **Graphics**: OpenGL 3.2+ / DirectX 11 compatible GPU
- **Display**: 1280x720 minimum resolution

### Recommended Requirements
- **OS**: Windows 11, macOS 12+, Linux (Ubuntu 20.04+)
- **RAM**: 8 GB
- **Storage**: 4 GB SSD space
- **Graphics**: Dedicated GPU with 2GB+ VRAM
- **Display**: 1920x1080 or higher

### Development Requirements
- **Unity Version**: 2022.3.10f1 or compatible
- **.NET Version**: .NET 4.x
- **IDE**: Visual Studio 2019+ or Rider

---

## 📁 Project Structure

```
Game-project/
├── Assets/
│   ├── Animation/                 # Animator controllers and animation clips
│   │   └── Character animations (walk, jump, idle, etc.)
│   ├── Art/                       # Custom art assets and sprites
│   ├── Characters/                # Character prefabs and models
│   ├── Prefab/                    # Reusable game object prefabs
│   │   ├── bullet.prefab          # Regular bullet prefab
│   │   ├── Missile.prefab         # Missile projectile
│   │   ├── grenades.prefab        # Grenade item
│   │   ├── Explosion.prefab       # Explosion effect
│   │   ├── Explosion2.prefab      # Alternative explosion
│   │   ├── Circle.prefab          # Circular object
│   │   └── booom.prefab           # Damage/sound effect
│   ├── Scenes/                    # Game scenes
│   │   ├── MainMenu.unity         # Main menu scene
│   │   └── GameScene.unity        # Main gameplay scene
│   ├── Scripts/                   # C# game scripts
│   │   ├── playController.cs      # Player movement and control
│   │   ├── Gun.cs                 # Weapon system and shooting
│   │   ├── bullet.cs              # Bullet behavior and physics
│   │   ├── playerHealth.cs        # Health management
│   │   ├── HealthBar.cs           # UI health bar display
│   │   ├── turnController.cs      # Turn management system
│   │   ├── chargeBar.cs           # Charge indicator UI
│   │   ├── Wind.cs                # Wind effect system
│   │   ├── cameraZoom.cs          # Camera control and zoom
│   │   ├── Ground.cs              # Ground/terrain system
│   │   ├── Booom.cs               # Explosion handling
│   │   ├── MainMenu.cs            # Menu interactions
│   │   └── Controller.cs          # Main game controller
│   ├── Sprites/                   # 2D sprite assets
│   ├── backgrond/                 # Background images and textures
│   └── TextMesh Pro/              # TextMesh Pro resources
├── Packages/
│   ├── manifest.json              # Package dependencies
│   └── packages-lock.json
├── ProjectSettings/               # Unity project configuration
│   ├── ProjectVersion.txt         # Unity version info
│   ├── ProjectSettings.asset      # Main project settings
│   ├── QualitySettings.asset      # Graphics quality levels
│   ├── InputManager.asset         # Input configuration
│   └── ...
└── README.md                      # This file
```

---

## 🚀 Installation & Setup

### Prerequisites
- **Unity Hub** installed
- **Unity 2022.3.10f1** installed (or compatible version)
- **Git** for cloning the repository

### Step 1: Clone the Repository

```bash
git clone https://github.com/122teerapat/Game-project.git
cd Game-project
```

### Step 2: Open Project in Unity

1. Open **Unity Hub**
2. Click **"Open"** or **"Add"**
3. Navigate to the cloned `Game-project` folder
4. Select the project folder
5. Unity will automatically load the project with version 2022.3.10f1

### Step 3: Wait for Imports

- Let Unity import all assets (this may take 2-5 minutes on first load)
- Watch the bottom right corner for import progress
- No errors should appear in the Console tab

### Step 4: Verify Setup

1. Open the **Scenes** folder in the Project window
2. Double-click `MainMenu.unity` to open it
3. Click the **Play** button in the Scene view
4. The game should start without errors

---

## 🎮 How to Play

### Main Menu
- **Click "Play"** or **"Start Game"** button to begin
- Select number of players if prompted
- Game initializes with players on the arena

### During Gameplay

#### Movement (Active Player)
- **A Key** - Move left
- **D Key** - Move right
- **Space Bar** - Jump
- **W Key** - Additional movement option

#### Aiming & Shooting
- **Move Mouse** - Aim the gun at target
- **Left Click** - Start charging the shot
- **Hold Left Click** - Increase shot power (watch the charge bar)
- **Release Left Click** - Fire the projectile
- The longer you hold, the more powerful the shot

#### Game Flow
1. Player 1 takes their turn (full control)
2. After shooting, camera switches to next player
3. Player 2 aims and shoots
4. Process repeats until only one player remains
5. Last player standing wins!

### Winning the Game
- Be the last player with health remaining
- Eliminate all opponents
- Survive longer than others

---

## 🎯 Game Mechanics

### Shooting System
- **Aiming**: Gun rotates to follow mouse cursor
- **Charging**: Power increases while holding left mouse button
- **Charge Bar**: Visual indicator shows current charge level (0-100%)
- **Force Range**: Bullets fire with power between `minShootForce` (5) and `maxShootForce` (20)
- **Speed Multiplier**: Adjustable multiplier for projectile velocity

### Physics System
- **Gravity**: Standard Earth gravity applied to bullets
- **Rigidbody2D**: Bullets use physics for realistic trajectory
- **Collision**: Bullets trigger on ground and player contact
- **Drag**: Optional air resistance on projectiles

### Health System
- **Player Health**: Tracks damage taken
- **Health Display**: Real-time UI health bar above each player
- **Damage on Impact**: Bullets deal damage based on impact force
- **Death Condition**: Player eliminated when health reaches 0

### Wind System
- **Dynamic Wind**: Wind can affect bullet trajectory
- **Visual Effect**: Wind direction displayed to players
- **Gameplay Impact**: Requires skill to adjust for wind effects
- **Randomized**: Wind changes between turns

### Turn System
- **Sequential Turns**: Players take turns in order
- **Turn Duration**: Each player can shoot once per turn
- **Auto Switch**: Camera and control automatically switch to next player
- **Turn Indicator**: UI shows whose turn it is

---

## 🎮 Controls

### Player Movement
| Key | Action |
|-----|--------|
| **A** | Move Left |
| **D** | Move Right |
| **Space** | Jump |
| **W** | Alternate Movement |

### Aiming & Shooting
| Input | Action |
|-------|--------|
| **Mouse Movement** | Aim Gun |
| **Left Mouse Click (Hold)** | Charge Shot |
| **Left Mouse Click (Release)** | Fire Projectile |

### Camera & UI
| Input | Action |
|-------|--------|
| **Mouse Scroll** | Zoom In/Out |
| **Escape** | Pause/Menu (if implemented) |

---

## ⚙️ Game Systems

### Player Controller System

**File:** `playController.cs`

- Manages player movement (left/right)
- Handles jump mechanics with force application
- Sprite flipping based on direction
- Animation state management (running, jumping)
- Integration with Gun component

**Key Variables:**
```csharp
public float speed = 10;              // Movement speed
public float jumpForce = 250;         // Jump force
public bool isJumping;                // Jump state
```

### Gun & Weapon System

**File:** `Gun.cs`

- Rotates gun to face mouse cursor
- Manages charge mechanics
- Handles bullet instantiation
- Controls fire rate and shot force

**Key Variables:**
```csharp
public float minShootForce = 5f;      // Minimum bullet speed
public float maxShootForce = 20f;     // Maximum bullet speed
public float chargeRate = 2f;         // Charge speed multiplier
```

**Charge Mechanics:**
- Left click to start charging
- Charge increases from `minShootForce` to `maxShootForce`
- Visual indicator shows progress
- Release to fire at current charge level

### Bullet System

**File:** `bullet.cs`

- Physics-based projectile movement
- Collision detection with ground and players
- Damage calculation on impact
- Explosion effect instantiation
- Auto-destroy after time limit

**Bullet Features:**
- Realistic gravity and trajectory
- Customizable speed and force
- Impact effects and sounds
- Damage to players on contact

### Health System

**File:** `playerHealth.cs` & `HealthBar.cs`

- Tracks current and maximum health
- Takes damage from bullet impacts
- Updates health bar UI in real-time
- Handles player elimination
- Respawn logic (if implemented)

### Turn Management

**File:** `turnController.cs`

- Manages turn order between players
- Switches active player control
- Updates Cinemachine camera target
- Disables/enables player controllers
- Handles player elimination

**Features:**
- Automatic turn cycling
- Camera smoothly follows active player
- Only active player can move/shoot
- Handles player death during turn

### Wind System

**File:** `Wind.cs`

- Generates random wind conditions
- Affects bullet trajectory
- Displays wind direction/magnitude
- Changes between turns
- UI indicator for wind effect

### Camera System

**File:** `cameraZoom.cs`

- Cinemachine virtual camera integration
- Dynamic zoom based on gameplay
- Smooth following of active player
- Adjustable zoom levels
- Focus on action area

---

## 🎭 Prefabs & Objects

### Player Prefabs
- **Character**: Main player character with animations
- **Gun**: Weapon mounted on player
- **HealthBar**: UI element showing health

### Projectile Prefabs
| Prefab | Type | Description |
|--------|------|-------------|
| `bullet.prefab` | Regular Bullet | Standard projectile |
| `Missile.prefab` | Missile | Larger, more damaging projectile |
| `grenades.prefab` | Grenade | Explosive projectile with delayed detonation |
| `explosionBullet.prefab` | Explosion Bullet | Bullet that explodes on impact |
| `explosionBullet2.prefab` | Alt Explosion | Alternative explosion variant |

### Effect Prefabs
| Prefab | Purpose |
|--------|---------|
| `Explosion.prefab` | Primary explosion effect |
| `Explosion2.prefab` | Secondary explosion variant |
| `booom.prefab` | Large impact/boom effect |

### Environment Prefabs
| Prefab | Purpose |
|--------|---------|
| `Circle.prefab` | Circular obstacle/object |
| `Ground.prefab` | Terrain/platform |

---

## 📜 Scripts Overview

### Core Scripts

#### `playController.cs`
**Purpose:** Player movement and character control
```
Main Functions:
- Update(): Handles input each frame
- Movement: A/D keys control horizontal speed
- Jumping: Space bar applies upward force
- Animation: Updates animator based on state
- Sprite Flipping: Faces direction of movement
```

#### `Gun.cs`
**Purpose:** Weapon system and shooting mechanics
```
Main Functions:
- Update(): Handles aiming and charging
- Shoot(): Instantiates bullet with calculated force
- Charge Management: Increases power while held
- Rotation: Points gun at mouse cursor
```

#### `bullet.cs`
**Purpose:** Projectile behavior and physics
```
Main Functions:
- Start(): Initialize rigidbody and velocity
- OnCollisionEnter2D(): Handle impacts
- Damage(): Apply damage to hit players
- Destroy(): Remove bullet from scene
```

#### `playerHealth.cs`
**Purpose:** Health tracking and damage handling
```
Main Functions:
- TakeDamage(): Reduce health by amount
- Die(): Handle player elimination
- Heal(): Restore health (if implemented)
- CheckHealth(): Verify alive status
```

#### `turnController.cs`
**Purpose:** Turn system and player switching
```
Main Functions:
- SwitchPlayer(): Activate next player
- DisablePlayer(): Remove control from player
- EnablePlayer(): Give control to player
- UpdateCamera(): Focus on active player
```

#### `HealthBar.cs`
**Purpose:** UI health display
```
Main Functions:
- UpdateHealthBar(): Adjust fill based on health
- ShowHealth(): Display health percentage
- AnimateBar(): Smooth health transitions
```

#### `chargeBar.cs`
**Purpose:** Charge indicator UI
```
Main Functions:
- updateCharge(): Set fill to charge percentage
- ShowBar(): Display when charging
- HideBar(): Hide when not charging
```

#### `Wind.cs`
**Purpose:** Wind effect mechanics
```
Main Functions:
- GenerateWind(): Create random wind
- ApplyWind(): Modify bullet trajectory
- GetWindForce(): Return current wind vector
```

#### `cameraZoom.cs`
**Purpose:** Camera control and following
```
Main Functions:
- FollowPlayer(): Set camera target
- ZoomToArea(): Adjust zoom level
- UpdateCamera(): Smooth camera movement
```

#### `Ground.cs`
**Purpose:** Ground/terrain management
```
Main Functions:
- CreateTerrain(): Generate playable ground
- TakeDamage(): Handle bullet impacts
- Repair(): Restore damaged areas (if implemented)
```

#### `Booom.cs`
**Purpose:** Explosion effects and damage
```
Main Functions:
- Explode(): Create explosion effect
- DealDamage(): Apply splash damage
- SpawnEffects(): Create visual particles
```

#### `MainMenu.cs`
**Purpose:** Menu interaction and game initialization
```
Main Functions:
- PlayGame(): Start gameplay
- QuitGame(): Exit application
- LoadScene(): Switch to game scene
```

#### `Controller.cs`
**Purpose:** Main game controller and manager
```
Main Functions:
- Initialize(): Set up game
- Update(): Main game loop
- CheckWinCondition(): Determine winner
- GameOver(): End game state
```

---

## 🎬 Scenes

### MainMenu.unity
**Purpose:** Game starting point and menu interface

**Contents:**
- Title display
- Play/Start button
- Settings panel (if implemented)
- Player selection (if applicable)
- Background and UI elements

**Flow:**
1. Game loads in Main Menu
2. Player clicks Play
3. Scene transitions to GameScene

### GameScene.unity
**Purpose:** Main gameplay environment

**Contents:**
- 2+ Player characters positioned at opposite ends
- Terrain and platforms
- Background with parallax effect
- Cinemachine virtual camera
- Canvas for UI (health bars, charge bar)
- Game manager/controller

**Game Setup:**
- Player 1 spawns on left side
- Player 2 spawns on right side
- Additional players positioned accordingly
- Camera focuses on active player
- Game loop begins

---

## 🎨 Graphics & Audio

### Sprites
- **Characters**: Animated player sprites with walking and jumping frames
- **Guns**: Weapon sprites that rotate with aiming
- **Bullets**: Projectile sprites for different ammunition types
- **Effects**: Explosion and impact visual effects
- **UI**: Health bars, charge indicators, interface elements
- **Background**: Game environment and atmospheric backdrops

### Animations
- **Character Walking**: Smooth walking animation cycle
- **Character Jumping**: Jump anticipation and air frames
- **Character Idle**: Standing and waiting animations
- **Gun Recoil**: Optional gun animation on fire
- **Explosions**: Animated explosion effects

### Particle Systems
- **Bullet Impact**: Particle effect on bullet collision
- **Explosion Effect**: Multiple explosion variants with particles
- **Dust/Debris**: Environmental destruction effects
- **Smoke**: Explosion smoke trails

### Background
- **Parallax Scrolling**: Multiple background layers at different speeds
- **Sky**: Static or animated sky background
- **Distant Elements**: Mountain or landscape elements
- **Theme**: Game-appropriate atmospheric environment

---

## 🔧 Development

### Opening the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/122teerapat/Game-project.git
   ```

2. **Open in Unity Hub**
   - Launch Unity Hub
   - Click "Add" or "Open"
   - Select the Game-project folder
   - Unity 2022.3.10f1 will be used automatically

3. **Import Assets**
   - Wait for Unity to import all assets
   - Check the Console for any errors

### Building the Game

```bash
# Via Unity Editor
File → Build Settings
→ Select target platform
→ Click "Build" or "Build and Run"
```

### Scripting Guidelines

- **Naming Convention**: 
  - Classes: `PascalCase` (e.g., `playController`)
  - Methods: `camelCase` (e.g., `TakeDamage()`)
  - Variables: `camelCase` (e.g., `currentHealth`)

- **Comments**: Add comments for complex logic
- **Serialization**: Use `[SerializeField]` for inspector access
- **Namespaces**: Use `using UnityEngine;` statements

### Adding New Features

**Example: New Weapon Type**
1. Create new bullet prefab
2. Add new script inheriting from `bullet.cs`
3. Implement custom behavior
4. Register in Gun's weapon list
5. Test in GameScene

**Example: New Player**
1. Duplicate player character
2. Assign to scene
3. Add to `turnController.possiblePlayer` list
4. Set unique spawn position
5. Test turn switching

---

## 📝 Controls Summary

| Action | Input |
|--------|-------|
| Move Left | A |
| Move Right | D |
| Jump | Space |
| Aim | Mouse Move |
| Charge Shot | Hold Left Click |
| Fire | Release Left Click |
| Zoom In/Out | Mouse Scroll |

---

## 🎓 Learning Resources

- [Unity Documentation](https://docs.unity.com)
- [Rigidbody2D Physics](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)
- [Cinemachine Guide](https://docs.unity3d.com/Manual/CinemachineDetailedDocumentation.html)
- [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [TextMesh Pro Documentation](https://docs.unity3d.com/Manual/TextMeshPro.html)

---



## 📄 License

This project is open source and available under the MIT License.

---

## 👤 Author

**Teerapat** (122teerapat)
- GitHub: [122teerapat](https://github.com/122teerapat)
- Repository: [Game-project](https://github.com/122teerapat/Game-project)

---

