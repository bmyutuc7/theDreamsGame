using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource scream;
    public GameObject player;
    public GameObject jumpcam;
    public GameObject flashing;
    public GameObject canvas3;

    public void Start()
    {
      

        StartCoroutine(EndJump());
    }

    // Update is called once per frame
    IEnumerator EndJump()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        scream.Play() ;
        jumpcam.SetActive(true);
      //  player.SetActive(false);
        flashing.SetActive(true);
        yield return new WaitForSecondsRealtime(2.0f);
        player.SetActive(true);
        //jumpcam.SetActive(false);
        flashing.SetActive(false);
        Time.timeScale = 1f;
        Enablemenu();
    }

    void Enablemenu()
    {


        canvas3.SetActive(true);
    }
}
