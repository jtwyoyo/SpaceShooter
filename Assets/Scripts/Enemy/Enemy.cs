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

        [SerializeField] private Manager.BoundaryManager boundaryManager;
        [SerializeField] private Manager.TextManager textManager;

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
                textManager.AddScore(enemyScore); ;
            }
        }

        Dictionary<string, float> bulletDamageMap = new Dictionary<string, float>()
        {
                { "NormalBullet", 1f },
                { "ShotgunBullet", 0.5f }
        };
    }
}