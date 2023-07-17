using System.Collections.Generic;
using UnityEngine;

namespace YoYo.SpaceShooter.Bullet
{
    public class Bullet : MonoBehaviour
    {
        public Dictionary<string, float> bulletDamageMap = new Dictionary<string, float>()
        {
                { "NormalBullet", 1f },
                { "ShotgunBullet", 0.5f }
        };

        private void Update()
        {
            if (gameObject.tag.Equals("NormalBullet")) {
                transform.position += Vector3.up * 5f * Time.deltaTime;
            }
            else if (gameObject.tag.Equals("ShotgunBullet"))
            {
                transform.position += Vector3.up * 7.5f * Time.deltaTime; ;
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