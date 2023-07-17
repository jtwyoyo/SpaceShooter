using UnityEngine;

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
        [SerializeField] private Manager.GameOverManager gameOverManager;
        [SerializeField] private Manager.UIManager uiManager;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
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

                uiManager.UpdateLivesText();
                if (lives <= 0)
                {
                    gameOverManager.GameOver();
                }
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
        }
    }
}
