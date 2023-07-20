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

        public void SetManager(Manager.Manager _manager)
        {
            manager = _manager;
        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            Bullet.Bullet bullet = collision.GetComponent<Bullet.Bullet>();
            enemyHealth -= bullet.damage;
            if (enemyHealth <= 0)
            {
                destroyByPlayer = true;
                manager.AddScore(enemyScore);
                Destroy(gameObject);
            }
        }
    }
}
