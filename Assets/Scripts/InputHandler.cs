#pragma strict
using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    public float minTimingWindow = 42f; // ms for Perfect
    public float maxTimingWindow = 84f; // ms for Good

    private float currentNodeTime;
    private float lastInputTime;
    private string lastResult = "Miss";

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                lastInputTime = Time.time;
                currentNodeTime = this.GetCurrentNodeArrivalTime();
                float delta = currentNodeTime - lastInputTime;

                if (delta < minTimingWindow)
                {
                    lastResult = "Perfect";
                    TriggerPhaseShift();
                }
                else if (delta < maxTimingWindow)
                {
                    lastResult = "Good";
                }
                else
                {
                    lastResult = "Miss";
                }
                
                // Log input result
                Debug.LogFormat("Input result: {0} (delta: {1:0.2f}ms)", lastResult, delta);
            }
        }
    }

    float GetCurrentNodeArrivalTime()
    {
        // Implement logic to calculate when the current node will appear
        // Placeholder: return Time.time + 0.5f;
        return Time.time + 0.5f; // Simplified for demo
    }

    void TriggerPhaseShift()
    {
        // Notify PulseTrack to activate phase shift
        // Or directly call PhaseShift.cs
    }
}