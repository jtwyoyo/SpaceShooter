using UnityEngine;

namespace YoYo.SpaceShooter.Bullet
{
    public class BulletHit : MonoBehaviour
    {
        void Update()
        {
            if (transform.position.y > 40f)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }
    }
}