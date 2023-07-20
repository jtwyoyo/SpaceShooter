using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.Manager
{
    public class MainMenuManager : MonoBehaviour
    {
        private void Update()
        {
            if (SceneManager.GetActiveScene().name.Equals("MainMenuScene") && Input.anyKey)
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            SceneManager.LoadScene("GameplayScene");
        }
    }
}