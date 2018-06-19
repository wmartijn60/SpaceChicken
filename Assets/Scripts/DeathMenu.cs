using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour 
{
    public string mainMenuLevel;
    public GameManager gameManager;

    public void RestartGame()
    {

        SceneManager.LoadScene(0);
    }
   
    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuLevel);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
