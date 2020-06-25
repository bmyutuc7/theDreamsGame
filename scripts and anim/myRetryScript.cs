using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myRetryScript: MonoBehaviour
{
    // Start is called before the first frame update
    private static bool GameIsPaused = false;
    public GameObject RetryUI;
    public GameObject pauseUI;
    public GameObject playerhand;
    

    void Update()
    {
        Time.timeScale = 0f;
        // playerhand.SetActive(true);
        pauseUI.SetActive(false);
             RetryUI.SetActive(true);
                
                    
          
        
       
    }




    public void myRetry()
    {
        playerhand.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Scene thisscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisscene.name);
    }
    public void LoadMenu()
    {
        playerhand.SetActive(true);
       
        Time.timeScale = 1f;
    
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }

   public void QuitGame()
    {
        Application.Quit();
    }
}
