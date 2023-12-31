using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.SpaceShip
{
    public class SpaceShipLives : MonoBehaviour
    {
        public int lives = 3;
        private bool invincible = false;

        private const float invincibleDuration = 3f;
        private const float transparency = 0.5f;
        private float invisibleEndTime;

        private SpriteRenderer spriteRenderer;
        private UIManager uiManager;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            uiManager = FindObjectOfType<UIManager>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy") && !invincible)
            {
                lives--;
                invincible = true;

                Color currentColor = spriteRenderer.color;
                spriteRenderer.color = new Color(currentColor.r, currentColor.g, currentColor.b, transparency);

                invisibleEndTime = Time.time + invincibleDuration;

                uiManager.UpdateLives(lives);
            }
        }

        private void Update()
        {
            if (invincible && Time.time >= invisibleEndTime)
            {
                invincible = false;

                Color currentColor = spriteRenderer.color;
                spriteRenderer.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
            }

            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
