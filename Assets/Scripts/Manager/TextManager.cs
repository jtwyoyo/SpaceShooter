using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.Manager
{
    public class TextManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI livesText;
        [SerializeField] private SpaceShip.SpaceShipLives spaceshipLives;

        private int score;

        private void Awake()
        {
            score = 0;

            UpdateScoreText();
            UpdateLivesText();
        }

        public void AddScore(int points)
        {
            score += points;
            UpdateScoreText();
        }

        public void UpdateLivesText()
        {
            livesText.text = "Lives: " + spaceshipLives.lives.ToString();
        }

        private void UpdateScoreText()
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}