# Bubble Game – WinForms (C#)

[![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20WinForms-blue.svg)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![.NET](https://img.shields.io/badge/.NET-6%2B%20or%20Framework%204.8-blueviolet.svg)](https://dotnet.microsoft.com/)
[![Build](https://img.shields.io/badge/Build-Visual%20Studio-informational.svg)](#build--run)
[![License: MIT](https://img.shields.io/badge/License-Educational-green.svg)](#license)

An academic Windows Forms game where the player pops moving bubbles, aiming for the highest score within a time limit.  
Focus: clean event-driven design, input handling, and testable game logic separated from the UI.

---

## 🧠 Features
- Animated bubbles with speed, size, and spawn variation  
- Mouse-based popping with hit detection and scoring  
- Timer-based rounds and game-over screen  
- Difficulty presets (speed, spawn rate, max bubbles)  
- Pause/resume and restart flow  
- Separated game logic layer (calculations, collisions) from WinForms UI

---

## 🗂 Project Structure
```text
.
├── BubbleGame.sln
├── BubbleGame/
│   ├── Forms/
│   │   ├── MainForm.cs            # game canvas, input, rendering loop
│   │   └── SettingsForm.cs        # difficulty and options
│   ├── Game/
│   │   ├── Bubble.cs              # bubble model (position, radius, velocity)
│   │   ├── GameState.cs           # score, timer, difficulty, pause state
│   │   ├── Spawner.cs             # spawn logic and rates
│   │   └── Collision.cs           # hit testing and bounds handling
│   ├── Rendering/
│   │   └── Renderer.cs            # double-buffer drawing helpers
│   ├── Properties/                # WinForms designer metadata
│   ├── Resources/                 # images/sounds (optional)
│   └── Program.cs                 # entry point
└── README.md
````

---

## 🏗️ Build & Run

### Visual Studio (Windows)

1. Open `BubbleGame.sln` in Visual Studio.
2. Ensure the startup project is `BubbleGame`.
3. Build (Debug or Release).
4. Press **F5** to run.

> If the project targets .NET Framework 4.8, make sure it’s installed.
> If it targets .NET 6+ (WinForms), ensure the corresponding SDK is installed.

---

## 🚀 Usage

* Click on moving bubbles to pop them and gain points.
* The round timer counts down; when it reaches zero, the game ends.
* Use the **Settings** window to change difficulty (speed, spawn rate).
* Press **Pause** to freeze motion; **Restart** to reset the round.

Controls:

* **Mouse Left**: pop bubble
* **Esc**: pause/resume (if implemented)
* **S**: open settings (if implemented)

---

## 🧪 Tests

The logic layer can be unit-tested without the WinForms UI.

Example (xUnit-style pseudo-code):

```csharp
public class CollisionTests
{
    [Fact]
    public void Hit_Is_Detected_When_Point_Inside_Bubble()
    {
        var b = new Bubble(centerX: 50, centerY: 50, radius: 20);
        Assert.True(Collision.HitTest(b, x: 55, y: 55));
    }

    [Fact]
    public void Bubble_Bounces_At_Bounds()
    {
        var b = new Bubble(5, 5, 10) { Velocity = new Vector( -2, -3 ) };
        b.Step(boundsWidth: 100, boundsHeight: 100);
        Assert.True(b.Velocity.X > 0 && b.Velocity.Y > 0);
    }
}
```

Run tests from a separate test project (recommended) or convert these into simple assert-based checks if you prefer no test framework.

---

## 🧱 Development Guidelines

* Keep rendering and input in `Forms/`, while rules and calculations stay in `Game/`.
* Use double buffering to avoid flicker during animation.
* Validate all user-configurable values (difficulty, spawn rate).
* Keep methods small and deterministic to simplify testing.
* Avoid heavy allocations inside the timer loop; reuse objects where possible.

---

## 🗺️ Roadmap

* Sounds and particle effects on pop
* Power-ups (freeze time, slow motion, multi-pop)
* High-score persistence (JSON)
* Multiple levels and background themes
* Touch input support

---

## 📄 License

MIT License (Educational Use)

Copyright (c) 2025 Ziv Gohasi

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to use
the Software for educational, research, or personal learning purposes,
including viewing, studying, and running the code.

Permission is NOT granted for commercial use, redistribution, or incorporation
of the Software into proprietary products without the author's explicit consent.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND.


