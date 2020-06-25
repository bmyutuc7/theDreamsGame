using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    static Animator anim;
	public float speed = 5.0f;
	public float rotationSpd = 100.0f;
	
    void Start()
    {
				anim = GetComponent<Animator>();
				Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
		float strafe = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime;
		strafe *= Time.deltaTime;
		
		transform.Translate(strafe, 0, translation);
		
	if(Input.GetButton("Fire1")){
		anim.SetBool("isAttacking",true);
    }
	else{
		anim.SetBool("isAttacking",false);
		
	}
	if(translation != 0){
		anim.SetBool("isWalking",true);
		anim.SetBool("isIdle", false);
	}
	else{
		anim.SetBool("isWalking",false);
		anim.SetBool("isIdle",true);
	}
	
	if(Input.GetKeyDown("escape")){
		Cursor.lockState = CursorLockMode.None;
}
	}
	
}
