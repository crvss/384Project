using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTemp
{
    public string playerName;
    public int score;
    public int level;

    public PlayerTemp(string playerName, int score, int level)
    {
        this.playerName = playerName;
        this.score = score;
        this.level = level;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }
    public void SetLevel(int level)
    {
        this.level = level;
    }

    public string GetPlayerName()
    {
        return this.playerName;
    }
    public override string ToString()
    {
        return $"{playerName} has {score} points at Level {level}";
    }
}