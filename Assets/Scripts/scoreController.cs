﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreController : MonoBehaviour
{
    [Header("Score Highlight")]
    public int scoreHighlightRange;
    //public CharacterSoundController sound;

    public int currentScore = 0;
    private int scoreCount;
    private int lastScoreHighlight = 0;


    private void Start()
    {
        // reset
        currentScore = 0;
        lastScoreHighlight = 0;
    }

    public float GetCurrentScore()
    {
        return currentScore;
    }

    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment;

        if (currentScore - lastScoreHighlight > scoreHighlightRange)
        {
            //sound.PlayScoreHighlight();
            lastScoreHighlight += scoreHighlightRange;
        }
    }

    public void FinishScoring()
    {
        // set high score
        if (currentScore > ScoreData.highScore)
        {
            ScoreData.highScore = currentScore;
        }
    }

    public void AddScore(int pointsToAdd)
    {
        currentScore += pointsToAdd;
    }
}
