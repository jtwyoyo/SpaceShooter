using System.Collections.Generic;
using UnityEngine;

namespace YoYo.SpaceShooter.Bullet
{
    public class Bullet : MonoBehaviour
    {
        public float damage;
        public float speed;

        private void Update()
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
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