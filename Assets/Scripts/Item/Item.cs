using UnityEngine;
using YoYo.SpaceShooter.SpaceShip;

namespace YoYo.SpaceShooter.Item
{ 
    public class Item : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out SpaceShipShooting spaceShipShooting))
            {
                spaceShipShooting.availableWeapons.Add(SpaceShipShooting.WeaponType.Shotgun);
            }

            Destroy(gameObject);
        }
    }
}