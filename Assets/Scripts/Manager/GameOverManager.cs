using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.Manager
{
    public class GameOverManager : MonoBehaviour
    {
        private void Update()
        {
            if (SceneManager.GetActiveScene().Equals("GameOverScene") && Input.anyKey)
            {
                BackToMainMenu();
            }
        }

        public void GameOver()
        {
            SceneManager.LoadScene("GameOverScene");
        }

        private void BackToMainMenu()
        {
            SceneManager.LoadScene("MainMenuScene");
        }
    }
}