using UnityEngine;
using TMPro;
using YoYo.SpaceShooter.SpaceShip;

namespace YoYo.SpaceShooter.Manager
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI livesText;

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