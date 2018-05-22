using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour 
{
    public string mainMenuLevel;
    public GameManager gameManager;

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuLevel);
    }
}
