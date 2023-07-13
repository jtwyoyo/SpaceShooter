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
            if (SceneManager.GetActiveScene().buildIndex.Equals(2) && Input.anyKey)
            {
                BackToMainMenu();
            }
        }

        public void GameOver()
        {
            SceneManager.LoadScene(2);
        }

        private void BackToMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}