using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyGreen : EnemyController
    {
        private void Start()
        {
            enemyHealth = 1;
            enemySpeed = 5;
            enemyScore = 100;
        }

        private void FixedUpdate()
        {
            MoveDownward();
        }

        private void OnDestroy()
        {
            if (destroyByPlayer)
            {
                UpdateScore(enemyScore);
            }
        }

        private void MoveDownward()
        {
            Vector3 movement = new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime;
            transform.position += movement;
        }
    }
}