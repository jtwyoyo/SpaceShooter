using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionManager : MonoBehaviour
{
    public Dictionary<Patterns, List<SpawnData>> spawnPatterns = new Dictionary<Patterns, List<SpawnData>>();

    public enum Patterns
    {
        Pattern1,
        Pattern2,
        Pattern3
    }

    public class SpawnData
    {
        public Vector3 position;
        public int enemyType;

        public SpawnData(Vector3 pos, int value)
        {
            position = pos;
            enemyType = value;
        }
    }

    private void Awake()
    {
        List<SpawnData> pattern1Positions = new List<SpawnData> {
            new SpawnData(new Vector3(-17.541f, 41f, 0f), 0),
            new SpawnData(new Vector3(-12.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-7.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-2.541f, 41f, 0f), 0),
            new SpawnData(new Vector3(2.541f, 41f, 0f), 0),
            new SpawnData(new Vector3(7.541f, 41f, 0f), 0),
            new SpawnData(new Vector3(12.541f, 41f, 0f), 0),
            new SpawnData(new Vector3(17.5f, 41f, 0f), 0),
        };
        spawnPatterns.Add(Patterns.Pattern1, pattern1Positions);

        List<SpawnData> pattern2Positions = new List<SpawnData> {
            new SpawnData(new Vector3(-17.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-12.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-2.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(2.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(12.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(17.5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-7.5f, 41f, 0f), 2),
            new SpawnData(new Vector3(7.5f, 41f, 0f), 2),
        };
        spawnPatterns.Add(Patterns.Pattern2, pattern2Positions);

        List<SpawnData> pattern3Positions = new List<SpawnData> {
            new SpawnData(new Vector3(-5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-4f, 41f, 0f), 0),
            new SpawnData(new Vector3(-3f, 41f, 0f), 0),
            new SpawnData(new Vector3(-2f, 41f, 0f), 0),
            new SpawnData(new Vector3(-1f, 41f, 0f), 0),
            new SpawnData(new Vector3(0f, 41f, 0f), 0),
            new SpawnData(new Vector3(1f, 41f, 0f), 0),
            new SpawnData(new Vector3(2f, 41f, 0f), 0),
            new SpawnData(new Vector3(3f, 41f, 0f), 0),
            new SpawnData(new Vector3(4f, 41f, 0f), 0),
            new SpawnData(new Vector3(5f, 41f, 0f), 0),
            new SpawnData(new Vector3(-10f, 41f, 0f), 1),
            new SpawnData(new Vector3(10f, 41f, 0f), 1),
        };
        spawnPatterns.Add(Patterns.Pattern3, pattern3Positions);
    }
}
