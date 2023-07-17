using UnityEngine;
using TMPro;
namespace YoYo.SpaceShooter.Manager
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI livesText;
        
        private SpaceShip.SpaceShipLives spaceshipLives;

        private void Awake()
        {
            spaceshipLives = FindObjectOfType<SpaceShip.SpaceShipLives>();
            UpdateLivesText();
        }

        public void UpdateLivesText()
        {
            livesText.text = "Lives: " + spaceshipLives.lives.ToString();
        }

        public void UpdateScoreText(int score)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}