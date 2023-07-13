using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyBlack : Enemy
    {
        [SerializeField] private GameObject shotgunItemPrefab;
        [SerializeField] private GameObject player;

        private void Update()
        {
            MoveTowardsPlayer();
        }

        private void MoveTowardsPlayer()
        {
            Vector3 direction = player.transform.position - transform.position;
            direction.Normalize();
            Vector3 movement = direction * enemySpeed * Time.fixedDeltaTime;
            transform.position += movement;
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
            }
        }
    }
}
