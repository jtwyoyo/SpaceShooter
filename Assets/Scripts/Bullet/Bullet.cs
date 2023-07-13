using UnityEngine;

namespace YoYo.SpaceShooter.Bullet
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Manager.BoundaryManager boundaryManager;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }
    }
}