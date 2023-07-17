using UnityEngine;
using TMPro;
namespace YoYo.SpaceShooter.Manager
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI livesText;
        [SerializeField] private SpaceShip.SpaceShipLives spaceshipLives;

        public void UpdateLivesText(int lives)
        {
            livesText.text = "Lives: " + lives.ToString();
        }

        public void UpdateScoreText(int score)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}