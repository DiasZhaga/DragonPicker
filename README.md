# **Dragon Picker - Unity Game**

## **Overview**
**Dragon Picker** is a Unity-based game where the player controls a shield to catch falling dragon eggs while avoiding missing them. If an egg is missed, a shield is removed, and if all shields are gone, the game restarts. The game features a **main menu**, **score system**, **sound effects**, and **visual effects**.

---

## **Features**
- 🐉 **Falling Dragon Eggs:** Eggs are dropped by the enemy dragon.
- 🛡️ **Energy Shields:** Shields protect eggs from hitting the ground.
- 💥 **Egg Collision Effects:** Explosions occur when an egg hits the ground.
- 🎵 **Sound Effects:** Egg collisions trigger audio feedback.
- 🎮 **Pause & Restart Mechanism:** Pause the game and restart upon losing all shields.
- 🏆 **Score System:** Score increases when eggs are successfully caught.
- 📜 **Main Menu:** Start the game from the menu.

---

## **Installation & Setup**
1. **Clone or Download** the project:
   ```sh
   git clone https://github.com/your-repo/DragonPicker.git
   ```
2. **Open the project** in **Unity** (Version 2022+ recommended).
3. **Ensure scenes are added** in **Build Settings**:
   - Go to `File → Build Settings`
   - Add `_0Scene` (Main Menu) and `_1Scene` (Game Scene)
4. Click **Play** ▶️ in Unity Editor to test the game.

---

## **Game Controls**

| Action       | Key/Button |
|-------------|-----------|
| Move Shield | Mouse Move |
| Pause       | `Space` |
| Return to Menu | `Esc` |
| Start Game | `Play` Button |

---

## **Code Structure & Roles**

### **1️⃣ `MainMenu.cs`**
- Handles scene transitions from the **main menu** to the **game**.
- Prevents invalid scene loading errors.

### **2️⃣ `DragonPicker.cs`**
- Manages **energy shields** and removes one when an egg is missed.
- Restarts the game when all shields are lost.

### **3️⃣ `DragonEgg.cs`**
- Controls **egg behavior** (falling, collision, destruction).
- Plays explosion effects when eggs hit the ground.

### **4️⃣ `EnemyDragon.cs`**
- Drops eggs at intervals.
- Moves the dragon left and right randomly.

### **5️⃣ `EnergyShield.cs`**
- Tracks the **player’s score**.
- Moves the shield based on **mouse position**.
- Plays **collision sounds** when an egg is caught.

### **6️⃣ `Pause.cs`**
- Allows pausing and resuming the game.
- Handles scene reloading for the menu.

---

