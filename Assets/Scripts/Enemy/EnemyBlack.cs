using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyBlack : EnemyController
    {
        [SerializeField] private GameObject shotgunItemPrefab;

        private void Start()
        {
            enemyHealth = 3;
            enemySpeed = 1;
            enemyScore = 400;
        }

        private void FixedUpdate()
        {
            MoveTowardsPlayer();
        }

        private void MoveTowardsPlayer()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                Vector3 direction = player.transform.position - transform.position;
                direction.Normalize();
                Vector3 movement = direction * enemySpeed * Time.fixedDeltaTime;
                transform.position += movement;
            }
        }

        private void OnDestroy()
        {
            if (destroyByPlayer)
            {
                if (Random.value <= 0.2f)
                {
                    GameObject shotgunItem = Instantiate(shotgunItemPrefab, gameObject.transform.position, Quaternion.identity);
                    shotgunItem.GetComponent<Rigidbody2D>().velocity = Vector2.down * 5f;
                }
                UpdateScore(enemyScore);
            }
        }
    }
}
