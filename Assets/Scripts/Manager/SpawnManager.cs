using System.Collections.Generic;
using UnityEngine;

namespace YoYo.SpaceShooter.Manager
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject spaceshipPrefab;
        [SerializeField] private GameObject greenEnemyPrefab;
        [SerializeField] private GameObject blackEnemyPrefab;
        [SerializeField] private GameObject orangeEnemyPrefab;
        [SerializeField] private SpawnPositionManager spawnPositions;

        private float waveCooldown = 2f;
        private float nextWaveTime;

        private void Awake()
        {
            SpawnPlayer(spaceshipPrefab, new Vector3(0f, 0f, 0f));
            nextWaveTime = Time.time;
        }

        private void Update()
        {
            if (Time.time >= nextWaveTime)
            {
                SpawnNextWave();
                nextWaveTime = Time.time + waveCooldown;
            }
        }

        private void SpawnNextWave()
        {
            int pattern = Random.Range(1, 4);

            switch (pattern)
            {
                case 1:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern1);
                    waveCooldown = 1f;
                    break;
                case 2:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern2);
                    waveCooldown = 1.5f;
                    break;
                case 3:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern3);
                    waveCooldown = 4f;
                    break;
            }
        }

        private void SpawnEnemy(GameObject enemyPrefab, Vector3 position)
        {
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }

        private void SpawnPlayer(GameObject spaceshipPrefab, Vector3 position)
        {
            Instantiate(spaceshipPrefab, position, Quaternion.identity);
        }

        private void SpawnPattern(SpawnPositionManager.Patterns patternKey)
        {
            if (spawnPositions.spawnPatterns.TryGetValue(patternKey, out List<SpawnPositionManager.SpawnData> spawnDataList))
            {
                foreach (SpawnPositionManager.SpawnData spawnData in spawnDataList)
                {
                    if (spawnData.enemyType.Equals(0)) SpawnEnemy(greenEnemyPrefab, spawnData.position);
                    if (spawnData.enemyType.Equals(1)) SpawnEnemy(orangeEnemyPrefab, spawnData.position);
                    if (spawnData.enemyType.Equals(2)) SpawnEnemy(blackEnemyPrefab, spawnData.position); ;
                }
            }
        }
    }
}
