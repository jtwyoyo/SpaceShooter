using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionManager : MonoBehaviour
{
    public Dictionary<string, List<Vector3>> spawnPatterns = new Dictionary<string, List<Vector3>>();

    private void Awake()
    {
        List<Vector3> pattern1Positions = new List<Vector3> {
            new Vector3(-17.541f, 41f, 0f),
            new Vector3(-12.5f, 41f, 0f),
            new Vector3(-7.5f, 41f, 0f),
            new Vector3(-2.541f, 41f, 0f),
            new Vector3(2.541f, 41f, 0f),
            new Vector3(7.541f, 41f, 0f),
            new Vector3(12.541f, 41f, 0f),
            new Vector3(17.5f, 41f, 0f),
        };
        spawnPatterns.Add("Pattern1", pattern1Positions);

        List<Vector3> pattern2Positions = new List<Vector3> {
            new Vector3(-17.5f, 41f, 0f),
            new Vector3(-12.5f, 41f, 0f),
            new Vector3(-2.5f, 41f, 0f),
            new Vector3(2.5f, 41f, 0f),
            new Vector3(12.5f, 41f, 0f),
            new Vector3(17.5f, 41f, 0f),
            new Vector3(-7.5f, 41f, 0f),
            new Vector3(7.5f, 41f, 0f),
        };
        spawnPatterns.Add("Pattern2", pattern2Positions);

        List<Vector3> pattern3Positions = new List<Vector3> {
            new Vector3(-5f, 41f, 0f),
            new Vector3(-4f, 41f, 0f),
            new Vector3(-3f, 41f, 0f),
            new Vector3(-2f, 41f, 0f),
            new Vector3(-1f, 41f, 0f),
            new Vector3(0f, 41f, 0f),
            new Vector3(1f, 41f, 0f),
            new Vector3(2f, 41f, 0f),
            new Vector3(3f, 41f, 0f),
            new Vector3(4f, 41f, 0f),
            new Vector3(5f, 41f, 0f),
            new Vector3(-10f, 41f, 0f),
            new Vector3(10f, 41f, 0f),
        };
        spawnPatterns.Add("Pattern3", pattern3Positions);
    }
}
