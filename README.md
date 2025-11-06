# Match3-Unity-Intern-Test 2025

This project is the submission for the **Unity Developer Internship Test (2025)** from IEC Games (Winter Wolf).  
The original project was provided as a base template, and my task was to modify and extend the gameplay following the given test requirements.

---

## Tasks Overview

### Task 1: Re-skin
- Replaced all existing item visuals with **Fish assets** included in the project.
- No logic changed — only visuals (sprite update).

---

###  Task 2: Change the Gameplay

**New gameplay rules implemented:**
- Tap an item on the board to move it into one of the **bottom cells**.
- Once moved to the bottom, the item **cannot return to the board**.
- When exactly **three identical items** are placed in the bottom area, they are **cleared automatically**.
- The game is **won** when the board is cleared.
- The game is **lost** if all bottom cells are filled without a valid match.

**Additional requirements completed:**
- Bottom area contains 5 cells.
- Winning screen UI implemented.
- Losing screen UI implemented.
- Added **Home Screen** with:
  - `Auto Play` button → the game plays automatically until it **wins** (0.5s delay per action).
  - `Auto Lose` button → the game plays automatically until it **loses** (0.5s delay per action).

---

### Task 3: Improve the Gameplay

Enhancements completed:
- Ensured the initial board contains **all fish types**.
- Added animations:
  - Item moving from board → bottom cell.
  - Scale-to-zero animation when a triple match clears.
- Added a **Time Attack Mode**:
  - New `Time Attack` button on Home Screen.
  - In this mode:
    - Player can move items **back from bottom to board**.
    - Player doesn't lose when bottom cells are full.
    - Player loses if the board is not cleared within **1 minute**.

---

## Work Done by Me (Key Contributions)

I directly implemented:

- Item movement logic:
  - Board → bottom slots
  - And in Time Attack mode → bottom slots → board
- Match detection system (identifying 3 identical items in bottom slots)
- Autoplay logic (win mode & lose mode, timed execution)
- Time Attack game mode logic (timer, rule overrides)
- Updated UI flow between Home → Gameplay → Result screens
- Animation integration for item movement and clearing

I kept the original project structure intact and added necessary scripts only where required.

---

## Notes

- No external assets were added.
- All logic was written manually to satisfy the test requirements.
- Autoplay was implemented deterministically to showcase understanding of board state evaluation.
- I couldn’t finish this within the expected 4-hour limit. I needed more time to understand the existing architecture and implement the gameplay properly. Instead of rushing, I prioritized code quality and correctness. This project truly helped me learn and improve.


---


