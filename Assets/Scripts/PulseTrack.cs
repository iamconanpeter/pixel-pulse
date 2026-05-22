#pragma strict
using UnityEngine;

public class PulseTrack : MonoBehaviour
{
    public float spawnInterval = 1.5f;
    public GameObject[] pulseNodes;
    private int currentNodeIndex = 0;

    void Start()
    {
        InvokeRepeating("SpawnPulseNode", 0f, spawnInterval);
    }

    void SpawnPulseNode()
    {
        GameObject node = Instantiate(pulseNodes[currentNodeIndex], transform.position, Quaternion.identity);
        currentNodeIndex = (currentNodeIndex + 1) % pulseNodes.Length;
        // Add logic to handle node color sequence here
    }
}