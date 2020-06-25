using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
     [SerializeField]
    public Stat health;

    [SerializeField]
    private Stat battery;

    [SerializeField]
    private Stat stamina;


   
    public GameObject jumpscare;
    public GameObject retrymenu;
    public void Awake()
    {
        health.Initialize();
        battery.Initialize();
        stamina.Initialize();
        retrymenu.SetActive(false);
        Time.timeScale = 1f;

    }


    private System.Collections.Generic.Dictionary<KeyCode, bool> keys = new System.Collections.Generic.Dictionary<KeyCode, bool>();
    private bool toggle = true;
    public new GameObject light;
    public Image imagetochange;
    public static float damage;
    public FirstPersonController FP;
   

    
    // Start is called before the first frame update
    void Start()
    {
        
        keys.Add(KeyCode.LeftShift, true);

        jumpscare.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      //  damage = health.CurrentVal - enemyhit.enemydamage;
     
     /* if (EH.enemydamage != 0)
        {
            Debug.Log("EH:" + EH.enemydamage);
            health.CurrentVal -= EH.enemydamage;
            EH.enemydamage = 0;
          
        }*/
           if(health.CurrentVal == 0)
        {


            // JUMP SCARE
            jumpscare.SetActive(true);

           // FindObjectOfType<GameManager>().EndGame();
        }
      
            if (Input.GetKeyDown(KeyCode.F))
        {
            if (toggle)
            {
                light.SetActive(false);
                toggle = !toggle;
            }
            else
            {
                light.SetActive(true);
                toggle = !toggle;

            }
        }
        if(light.activeInHierarchy == true)
        {
            battery.CurrentVal -= 10;
        }
        else
        {
            battery.CurrentVal += 5;
        }

        if(battery.CurrentVal == 0)
        {
           
            light.SetActive(false);
        }
        if (battery.CurrentVal <= 500)
        {
            imagetochange.color = Color.red;
           
        }
        else{
            imagetochange.color = Color.grey;
        }




       if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            stamina.CurrentVal -= 20;

        }
        else if (stamina.CurrentVal == 0)
        {
           


        }
        
 
 

        if (Input.GetKey(KeyCode.LeftShift) == true && keys[KeyCode.LeftShift] == true)      
            {
            if (stamina.CurrentVal <= 5 && stamina.CurrentVal >= 0)
            {
                
                FP.AllowSprint = false; 

                keys[KeyCode.LeftShift] = false;
                
            }
            else if(stamina.CurrentVal >= 20 && FP.AllowSprint == false)
            { //sound na humihingal
                FP.AllowSprint = true;
                
                keys[KeyCode.LeftShift] = true;
            }
            else
            {
                //sound na napapagod/tumatakbo
                stamina.CurrentVal -= 1;
                keys[KeyCode.LeftShift] = true;
            }
        }
        else
        {
            
            stamina.CurrentVal += 1;
            keys[KeyCode.LeftShift] = true;
        }
    



    }

  
}
