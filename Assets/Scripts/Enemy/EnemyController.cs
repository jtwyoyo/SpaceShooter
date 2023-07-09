using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyController : MonoBehaviour
    {
        protected bool destroyByPlayer = false;
        protected float enemyHealth;
        protected float enemySpeed;
        protected int enemyScore;

        private UIManager uiManager;

        private void Awake()
        {
            uiManager = FindObjectOfType<UIManager>();
        }

        protected void Update()
        {
            if (enemyHealth <= 0)
            {
                destroyByPlayer = true;
                Destroy(gameObject);
            }
            if (transform.position.y < -3f || transform.position.y > 43 
                || transform.position.x < -23f || transform.position.x > 23f)
            {
                Destroy(gameObject);
            }
        }

        protected void UpdateScore(int score)
        {
            uiManager.AddScore(score);
        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("NormalBullet")) 
            {
                enemyHealth -= 1f;
            }
            if (collision.CompareTag("ShotgunBullet"))
            {
                enemyHealth -= 0.5f;
            }
        }
    }
}