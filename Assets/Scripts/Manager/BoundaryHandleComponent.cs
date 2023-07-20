using UnityEngine;

namespace YoYo.SpaceShooter.Manager
{
    public class BoundaryHandleComponent : MonoBehaviour
    {
        private const float boundaryBottom = -3f;
        private const float boundaryTop = 43f;
        private const float boundaryLeft = -23f;
        private const float boundaryRight = 23f;

        private void Update()
        {
            CheckBoundary();
        }

        private void CheckBoundary()
        {
            if (transform.position.y < boundaryBottom || transform.position.y > boundaryTop || transform.position.x < boundaryLeft || transform.position.x > boundaryRight)
            {
                Destroy(gameObject);
            }
        }
    }
}