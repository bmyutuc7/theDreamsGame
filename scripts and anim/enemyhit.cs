using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour
{

	public GameObject Player;
    public float enemydamage = 0;
    public Player PL;
	void OnTriggerEnter (Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            Debug.Log(enemydamage);
            enemydamage += 1;
            PL.health.CurrentVal -= enemydamage;
        }
        if (enemydamage != 0)
        {
            Debug.Log("CURRENT EH DAMAGE:" + enemydamage);
            enemydamage = 0;

        }



        //	player.transform.position = teleportTarget.transform.position;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
