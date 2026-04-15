# 15-Days-15-Games-Day-07-Split-Screen-Racing

This is the seventh game from my "15 Days 15 Games" challenge. It is a complete 3D, local two-player, split-screen racing game.

## 🚀 About the Game
Two players compete on a shared track, each with their own half of the screen as their viewport. They must navigate around obstacles and other moving vehicles to be the first to cross the finish line. If a player drives off the track, they automatically lose.

## 💡 Technical Highlights
* **Engine:** Unity (3D)
* **Scalable Local Multiplayer Input:** The project utilizes a single `PlayerController.cs` script for both players. A public integer, `inputId`, is used to dynamically construct the names of the input axes (e.g., `"Horizontal" + inputId`). This is a highly efficient and scalable method for managing multiple local player inputs without code duplication.
* **Split-Screen Camera System:** The game features a two-camera setup. Each camera is configured with a different "Viewport Rect" (one for `x=0, w=0.5` and the other for `x=0.5, w=0.5`) to render the two player perspectives side-by-side. Each camera uses a `FollowPlayer.cs` script to maintain a consistent third-person view.
* **Player-Specific Camera Switching:** Each player can independently switch between a third-person camera and a first-person hood camera, demonstrating per-player camera management.
* **Tag-Based Win/Loss Conditions:** The `PlayerController` uses `OnTriggerEnter` to detect collisions with "FinishLine" and "GameOver" triggers. It then uses the player's own tag ("Player1" or "Player2") to correctly inform the `GameManager` which player has won or lost the race.

## ▶️ Play the Game!
You can play the game in your browser on its itch.io page:
**https://shanmukha.itch.io/split-screen-racers**

