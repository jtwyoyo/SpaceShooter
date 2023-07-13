using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoYo.SpaceShooter.Manager
{
    public class MainMenuManager : MonoBehaviour
    {
        private void Update()
        {
            if (SceneManager.GetActiveScene().buildIndex.Equals(0) && Input.anyKey)
            {
                StartGame();
            }
        }
        private void StartGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}