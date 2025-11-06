using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : ScriptableObject
{
    public int BoardSizeX = 6;

    public int BoardSizeY = 6;

    public int NumberOfEmptyCells = 5;

    public int MatchesMin = 3;

    public int LevelMoves = 16;

    public float LevelTime = 6f;

    public float TimeForHint = 5f;
}
