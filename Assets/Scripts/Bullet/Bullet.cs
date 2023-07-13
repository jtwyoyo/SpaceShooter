﻿using UnityEngine;

namespace YoYo.SpaceShooter.Bullet
{
    public class Bullet : MonoBehaviour
    {
        private bool isOutSideBoundary;

        private const float boundaryBottom = -3f;
        private const float boundaryTop = 43f;
        private const float boundaryLeft = -23f;
        private const float boundaryRight = 23f;

        private void Awake()
        {
            isOutSideBoundary = transform.position.y < boundaryBottom || transform.position.y > boundaryTop || transform.position.x < boundaryLeft || transform.position.x > boundaryRight;
        }

        private void Update()
        {
            CheckBoundary();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }

        private void CheckBoundary()
        {
            if (isOutSideBoundary)
            {
                Destroy(gameObject);
            }
        }
    }
}