using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myPause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
    public GameObject player;
   

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                myResume();
            } else
            {
                myownPause();
            }
        }
    }


    public void myResume()
    {
        player.SetActive(true);
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

   public void myownPause()
    {
        player.SetActive(false);
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void myRetry()
    {
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Scene thisscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisscene.name);
    }
    public void LoadMenu()
    {
        player.SetActive(true);
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("MainMenu" , LoadSceneMode.Single);
    }

   public void QuitGame()
    {
        Application.Quit();
    }
}
