using UnityEngine;

namespace YoYo.SpaceShooter.Manager
{
    public class Manager : MonoBehaviour
    {
        private int score;
        private UIManager uiManager;

        private void Awake()
        {
            uiManager = FindObjectOfType<UIManager>();
            score = 0;
            AddScore(0);
        }

        public void AddScore(int points)
        {
            score += points;
            uiManager.UpdateScoreText(score);
        }
    }
}