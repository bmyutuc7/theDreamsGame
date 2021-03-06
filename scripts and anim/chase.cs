﻿using System.Collections;
using UnityEngine;

public class chase : MonoBehaviour
{ 		public Transform player;
		public Animator anim;
		public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
			anim = GetComponent<Animator>();
			rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {	
		Vector3 direction = player.position - this.transform.position;
		float angle = Vector3.Angle(direction,this.transform.forward);
        if(Vector3.Distance(player.position, this.transform.position) < 10 && angle < 90)
		{
			//Vector3 direction = player.position - this.transform.position;
			direction.y = 0;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
			
			anim.SetBool("isIdle",false);
			if(direction.magnitude > 1.5)
			{
				this.transform.Translate(0,0,0.05f);
				anim.SetBool("isWalking",true);
				anim.SetBool("isAttacking",false);
			}
			else{
				anim.SetBool("isAttacking",true);
				anim.SetBool("isWalking",false);
			}	
		} else
			{
				anim.SetBool("isIdle",true);
				anim.SetBool("isWalking",false);
				anim.SetBool("isAttacking",false);
			}
    }
} 
