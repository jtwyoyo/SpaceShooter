using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace YoYo.SpaceShooter.Enemy
{
    public class Enemy : MonoBehaviour
    {
        protected bool destroyByPlayer = false;

        [SerializeField]  protected float enemyHealth;
        [SerializeField]  protected float enemySpeed;
        [SerializeField]  protected int enemyScore;
        [SerializeField] private UIManager uiManager;

        private bool isOutSideBoundary;

        private const float boundaryBottom = -3f;
        private const float boundaryTop = 43f;
        private const float boundaryLeft = -23f;
        private const float boundaryRight = 23f;

        private void Awake()
        {
            isOutSideBoundary = transform.position.y < boundaryBottom || transform.position.y > boundaryTop || transform.position.x < boundaryLeft || transform.position.x > boundaryRight;
        }

        protected void Update()
        {
            if (isOutSideBoundary)
            {
                Destroy(gameObject);
            }
        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (bulletDamageMap.TryGetValue(collision.tag, out float damage))
            {
                enemyHealth -= damage;
            }
            if (enemyHealth <= 0)
            {
                destroyByPlayer = true;
                Destroy(gameObject);
            }
        }

        private void OnDestroy()
        {
            if (destroyByPlayer)
            {
                uiManager.AddScore(enemyScore); ;
            }
        }

        Dictionary<string, float> bulletDamageMap = new Dictionary<string, float>()
        {
                { "NormalBullet", 1f },
                { "ShotgunBullet", 0.5f }
        };
    }
}