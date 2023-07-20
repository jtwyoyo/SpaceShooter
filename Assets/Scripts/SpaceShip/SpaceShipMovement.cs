using UnityEngine;

namespace YoYo.SpaceShooter.SpaceShip
{
    public class SpaceShipMovement : MonoBehaviour
    {
        private const float speed = 5f;
        private bool useWASD;

        private void Awake()
        {
            useWASD = true;
        }

        private void Update()
        {
            HandleMovement();
            HandleSwapControl();
        }

        private void HandleMovement()
        {
            float horizontalInput = useWASD ? Input.GetAxis("Horizontal") : Input.GetAxis("AltHorizontal");
            float verticalInput = useWASD ? Input.GetAxis("Vertical") : Input.GetAxis("AltVertical");

            Vector3 movement = speed * Time.deltaTime * new Vector3(horizontalInput, verticalInput, 0f);
            Vector3 newPosition = transform.position + movement;

            newPosition.x = Mathf.Clamp(newPosition.x, -20f, 20f);
            newPosition.y = Mathf.Clamp(newPosition.y, 0f, 40f);

            transform.position = newPosition;
        }

        private void HandleSwapControl()
        {
            if (Input.GetKeyDown(KeyCode.V) && useWASD)
            {
                useWASD = false;
            }
            else if (Input.GetKeyDown(KeyCode.V) && !useWASD)
            {
                useWASD = true;
            }
        }
    }
}
