using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public int score;
    public string playerName;

    public Score(int score, string playerName)
    {
        this.score = score;
        this.playerName = playerName;
    }
}