using System.Collections.Generic;
using UnityEngine;

namespace YoYo.SpaceShooter.Manager
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject spaceshipPrefab;
        [SerializeField] private GameObject[] enemyPrefabs;
        [SerializeField] private SpawnPositionManager spawnPositions;
        [SerializeField] private Manager manager;

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
            SpawnPositionManager.Patterns pattern = (SpawnPositionManager.Patterns)Random.Range(0, 2);

            switch (pattern)
            {
                case SpawnPositionManager.Patterns.Pattern1:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern1);
                    waveCooldown = 1f;
                    break;
                case SpawnPositionManager.Patterns.Pattern2:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern2);
                    waveCooldown = 1.5f;
                    break;
                case SpawnPositionManager.Patterns.Pattern3:
                    SpawnPattern(SpawnPositionManager.Patterns.Pattern3);
                    waveCooldown = 4f;
                    break;
            }
        }

        private void SpawnEnemy(SpawnPositionManager.EnemyType enemyType, Vector3 position)
        {
            GameObject enemyPrefab = enemyPrefabs[(int)enemyType];
            GameObject enemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            Enemy.Enemy enemyScript = enemy.GetComponent<Enemy.Enemy>();
            enemyScript.SetManager(manager);
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
                    SpawnEnemy(spawnData.enemyType, spawnData.position);
                }
            }
        }
    }
}
