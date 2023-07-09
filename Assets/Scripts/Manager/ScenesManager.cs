using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.Manager
{
    public class ScenesManager : MonoBehaviour
    {
        private string currentScene;

        private void Start()
        {
            currentScene = SceneManager.GetActiveScene().name;
        }

        private void Update()
        {
            if (currentScene == "MainMenuScene")
            {
                if (Input.anyKeyDown)
                {
                    SceneManager.LoadScene("GameplayScene");
                }
            }
            else if (currentScene == "GameOverScene")
            {
                if (Input.anyKeyDown)
                {
                    SceneManager.LoadScene("MainMenuScene");
                }
            }
        }
    }
}