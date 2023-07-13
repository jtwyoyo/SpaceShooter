using UnityEngine;

namespace YoYo.SpaceShooter.SpaceShip
{
    public class SpaceShipMovement : MonoBehaviour
    {
        private const float speed = 5f;

        private void Update()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;
            Vector3 newPosition = transform.position + movement;

            newPosition.x = Mathf.Clamp(newPosition.x, -20f, 20f);
            newPosition.y = Mathf.Clamp(newPosition.y, 0f, 40f);

            transform.position = newPosition;
        }
    }
}
