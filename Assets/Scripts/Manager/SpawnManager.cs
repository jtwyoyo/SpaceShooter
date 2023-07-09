using UnityEngine;

namespace YoYo.SpaceShooter.Manager
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject spaceshipPrefab;
        [SerializeField] private GameObject greenEnemyPrefab;
        [SerializeField] private GameObject blackEnemyPrefab;
        [SerializeField] private GameObject orangeEnemyPrefab;
        
        private float waveCooldown = 2f;
        private float nextWaveTime;

        private void Start()
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
                    SpawnPattern1();
                    waveCooldown = 1f;
                    break;
                case 2:
                    SpawnPattern2();
                    waveCooldown = 1.5f;
                    break;
                case 3:
                    SpawnPattern3();
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

        private void SpawnPattern1()
        {
            SpawnEnemy(greenEnemyPrefab, new Vector3(-17.541f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-12.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-7.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-2.541f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(2.541f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(7.541f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(12.541f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(17.5f, 41f, 0f));
        }

        private void SpawnPattern2()
        {
            SpawnEnemy(greenEnemyPrefab, new Vector3(-17.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-12.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-2.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(2.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(12.5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(17.5f, 41f, 0f));
            SpawnEnemy(blackEnemyPrefab, new Vector3(-7.5f, 41f, 0f));
            SpawnEnemy(blackEnemyPrefab, new Vector3(7.5f, 41f, 0f));
        }

        private void SpawnPattern3()
        {
            SpawnEnemy(greenEnemyPrefab, new Vector3(-5f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-4f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-3f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-2f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(-1f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(0f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(1f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(2f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(3f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(4f, 41f, 0f));
            SpawnEnemy(greenEnemyPrefab, new Vector3(5f, 41f, 0f));
            SpawnEnemy(orangeEnemyPrefab, new Vector3(-10f, 41f, 0f));
            SpawnEnemy(orangeEnemyPrefab, new Vector3(10f, 41f, 0f));
        }
    }
}