#pragma strict
using UnityEngine;
using System.Collections;

public class ScoringSystem : MonoBehaviour
{
    public int baseScore = 10;
    public int maxChainMultiplier = 16;
    public float overheatThreshold = 500f; // ms to break chain
    
    private int currentScore = 0;
    private int currentChain = 0;
    private float lastHitTime = 0f;
    private bool isOverheated = false;

    void Start()
    {
        ResetChain();
    }

    public void RecordHit(string hitType)
    {
        if (isOverheated) return;
        
        float currentTime = Time.time;
        
        // Check if chain is broken
        if (currentTime - lastHitTime > overheatThreshold / 1000f)
        {
            ResetChain();
        }
        
        lastHitTime = currentTime;
        
        if (hitType == "Perfect")
        {
            currentChain++;
            int multiplier = Mathf.Min(currentChain, maxChainMultiplier);
            currentScore += baseScore * multiplier;
            Debug.LogFormat("Perfect! Chain x{0}, Score: {1}", multiplier, currentScore);
        }
        else if (hitType == "Good")
        {
            currentChain = 0;
            currentScore += baseScore;
            Debug.LogFormat("Good! Score: {0}", currentScore);
        }
        else
        {
            currentChain = 0;
            Debug.LogFormat("Miss! Score: {0}", currentScore);
        }
    }

    public void ResetChain()
    {
        currentChain = 0;
        lastHitTime = Time.time;
    }

    public void TriggerOverheat()
    {
        isOverheated = true;
        Debug.Log("Overheat! Chain broken!");
    }

    public void ResetOverheat()
    {
        isOverheated = false;
        ResetChain();
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public int GetCurrentChain()
    {
        return currentChain;
    }
}