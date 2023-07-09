using UnityEngine;
using YoYo.SpaceShooter.SpaceShip;

namespace YoYo.SpaceShooter.Item
{ 
    public class ItemPickUp : MonoBehaviour
    {
        private void Update()
        {
            if (transform.position.y < -2f)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                SpaceShipShooting spaceShipShooting = collision.gameObject.GetComponent<SpaceShipShooting>();
                if (spaceShipShooting != null)
                {
                    spaceShipShooting.hasShotgun = true;
                }

                Destroy(gameObject);
            }
        }
    }
}