using UnityEngine;

namespace YoYo.SpaceShooter.SpaceShip
{
    public class SpaceShipShooting : MonoBehaviour
    {
        [SerializeField] private GameObject normalBulletPrefab;
        [SerializeField] private GameObject shotgunBulletPrefab;
        [SerializeField] private Transform bulletSpawnPoint;

        private string weapon;
        private float nextShootTime;
        public bool hasShotgun { get; set; }

        private void Start()
        {
            weapon = "Normal";
            hasShotgun = false;
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
                if (Input.GetKeyDown(KeyCode.Space) && weapon == "Normal")
                {
                    ShootNormalBullet();
                }
                else if (Input.GetKeyDown(KeyCode.Space) && weapon == "Shotgun")
                {
                    ShootShotgunBullets();
                }
            }
        }

        private void ShootNormalBullet()
        {
            GameObject bullet = Instantiate(normalBulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 5f;

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
                bullet.GetComponent<Rigidbody2D>().velocity = spreadDirection * 7.5f;
            }

            nextShootTime = Time.time + 0.5f;
        }

        private void HandleWeaponSwap()
        {
            if (Input.GetKeyDown(KeyCode.Tab) && hasShotgun && weapon == "Normal")
            {
                weapon = "Shotgun";
            } 
            else if (Input.GetKeyDown(KeyCode.Tab) && weapon == "Shotgun")
            {
                weapon = "Normal";
            }
        }
    }
}