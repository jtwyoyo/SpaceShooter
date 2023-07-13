using System.Collections.Generic;
using UnityEngine;

namespace YoYo.SpaceShooter.SpaceShip
{
    public class SpaceShipShooting : MonoBehaviour
    {
        [SerializeField] private GameObject normalBulletPrefab;
        [SerializeField] private GameObject shotgunBulletPrefab;
        [SerializeField] private Transform bulletSpawnPoint;

        private float nextShootTime;

        public List<WeaponType> availableWeapons = new List<WeaponType>();
        private int currentWeaponIndex;
        private WeaponType currentWeapon;

        private void Awake()
        {
            availableWeapons.Add(WeaponType.Normal);
            currentWeapon = WeaponType.Normal;
            currentWeaponIndex = 0;
        }
        private void Update()
        {
            HandleShooting();
            HandleWeaponSwap();
        }

        private void HandleShooting()
        {
            if (Time.time >= nextShootTime)
            {
                if (Input.GetKeyDown(KeyCode.Space) && currentWeapon == WeaponType.Normal)
                {
                    ShootNormalBullet();
                }
                else if (Input.GetKeyDown(KeyCode.Space) && currentWeapon == WeaponType.Shotgun)
                {
                    ShootShotgunBullets();
                }
            }
        }

        private void ShootNormalBullet()
        {
            GameObject bullet = Instantiate(normalBulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.transform.position += Vector3.up * 5f * Time.deltaTime;

            nextShootTime = Time.time + 0.25f;
        }

        private void ShootShotgunBullets()
        {
            int numBullets = 7;
            float spreadAngle = 30f;

            for (int i = 0; i < numBullets; i++)
            {
                float angle = spreadAngle * ((float)i / (numBullets - 1) - 0.5f);
                Quaternion rotation = Quaternion.Euler(0f, 0f, angle);
                Vector2 spreadDirection = rotation * Vector2.up;

                GameObject bullet = Instantiate(shotgunBulletPrefab, bulletSpawnPoint.position, rotation);
                bullet.transform.position += (Vector3)(spreadDirection * 7.5f * Time.deltaTime);
            }

            nextShootTime = Time.time + 0.5f;
        }

        private void HandleWeaponSwap()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                currentWeaponIndex = (currentWeaponIndex + 1) % availableWeapons.Count;
                currentWeapon = availableWeapons[currentWeaponIndex];
            }
        }

        public enum WeaponType
        {
            Normal,
            Shotgun
        }
    }
}