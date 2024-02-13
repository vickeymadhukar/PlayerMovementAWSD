# Unity MoveAWSD Script

## Description

This Unity script (`moveAWSD.cs`) allows for basic player movement using the W, A, S, and D keys. It is designed to be attached to a GameObject in a Unity scene and utilizes the Rigidbody2D component for physics-based movement.

## Features

- Player movement using W, A, S, D keys.
- Adjustable movement speed through the Unity Editor.

## How to Use

1. Attach the `moveAWSD` script to your player GameObject in the Unity Editor.
2. Adjust the `speed` parameter in the Unity Editor to control the movement speed.
3. Run the Unity scene.
4. Use the W, A, S, and D keys to move the player in the corresponding directions.

## Unity Version Compatibility

This script is intended for use with Unity and has been tested on version [Insert Unity Version].

## Code Structure

- `moveAWSD.cs`: Main script file containing the player movement logic.
  
## Example

```csharp
// Attach this script to a GameObject in Unity
// Adjust the speed parameter in the Unity Editor
// Use W, A, S, D keys to move the player
public class moveAWSD : MonoBehaviour
{
    public float speed;
    private float moveinx;
    private float moveiny;
    private Rigidbody2D rb;

    // ... (rest of your script)
}
