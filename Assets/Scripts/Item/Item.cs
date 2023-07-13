using UnityEngine;
using YoYo.SpaceShooter.SpaceShip;

namespace YoYo.SpaceShooter.Item
{ 
    public class Item : MonoBehaviour
    {
        [SerializeField] private Manager.BoundaryManager boundaryManager;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                if (collision.gameObject.TryGetComponent(out SpaceShipShooting spaceShipShooting))
                {
                    spaceShipShooting.availableWeapons.Add(SpaceShipShooting.WeaponType.Shotgun);
                }

                Destroy(gameObject);
            }
        }
    }
}