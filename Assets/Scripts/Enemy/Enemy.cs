using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class Enemy : MonoBehaviour
    {
        protected bool destroyByPlayer = false;
        [SerializeField] protected float enemyHealth;
        [SerializeField] protected float enemySpeed;
        [SerializeField] protected int enemyScore;

        private Manager.Manager manager;

        private void Awake()
        {
            manager = FindObjectOfType<Manager.Manager>();
        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("NormalBullet") || collision.CompareTag("ShotgunBullet"))
            {
                Bullet.Bullet bullet = collision.GetComponent<Bullet.Bullet>();
                if (bullet != null)
                {
                    if (bullet.bulletDamageMap.TryGetValue(collision.tag, out float damage))
                    {
                        enemyHealth -= damage;
                        if (enemyHealth <= 0)
                        {
                            destroyByPlayer = true;
                            manager.AddScore(enemyScore);
                            Destroy(gameObject);
                        }
                    }
                }
            }
        }
    }
}
