using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyOrange : EnemyController
    {
        private const float rotationSpeed = 30f;

        private void Start()
        {
            enemyHealth = 1;
            enemySpeed = 2;
            enemyScore = 300;
        }

        private void FixedUpdate()
        {
            MoveAndRotateTowardsPlayer();
        }

        private void OnDestroy()
        {
            UpdateScore(enemyScore);
        }

        private void MoveAndRotateTowardsPlayer()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                Vector3 direction = player.transform.position - transform.position;
                direction.Normalize();
                Vector3 movement = direction * enemySpeed * Time.fixedDeltaTime;
                transform.position += movement;

                Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, -direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
            }
        }
    }

}
