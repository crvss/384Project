using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string playerName;
    public int score;
    public int level;

    public PlayerData(string playerName, int score, int level)
    {
        this.playerName = playerName;
        this.score = score;
        this.level = level;
    }

    public override string ToString()
    {
        return $"{playerName} has {score} points at Level {level}";
    }
}
