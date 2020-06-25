using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titanchase : MonoBehaviour
{
       public Transform player;
		public Animator anim;
    void Start()
    {		
			anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {	Vector3 direction = player.position - this.transform.position;
		float angle = Vector3.Angle(direction,this.transform.forward);
		  
		  if(Vector3.Distance(player.position, this.transform.position) >=11 && Vector3.Distance(player.position, this.transform.position) <=20 && angle < 90)
				{anim.SetBool("isIdle",false);
					anim.SetBool("isShouting",true);
					}
				else{
					anim.SetBool("isIdle",true);
					anim.SetBool("isShouting",false);
				anim.SetBool("isRunning",false);
				anim.SetBool("isAttacking",false);
				}
				
					if(Vector3.Distance(player.position, this.transform.position) < 15 && angle < 90)
						{
						//Vector3 direction = player.position - this.transform.position;
						direction.y = 0;
            anim.SetBool("isIdle", false);
            anim.SetBool("isRunning", true);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.5f);
                
         
            if (direction.magnitude > 2.5)
						{
						this.transform.Translate(0,0,0.20f);
						anim.SetBool("isRunning",true);
						anim.SetBool("isAttacking",false);
						}
						else{
						anim.SetBool("isAttacking",true);
						anim.SetBool("isRunning",false);
                      

            }	
			} else
								{
								//anim.SetBool("isShouting",true);
				anim.SetBool("isIdle",true);
				anim.SetBool("isRunning",false);
				anim.SetBool("isAttacking",false);
			}
				
	}
	}
 
