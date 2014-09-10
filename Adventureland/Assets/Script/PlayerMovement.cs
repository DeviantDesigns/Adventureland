using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float moveSpeed = 10.0f;
	public float rotateSpeed = 50.0f;
	public float forwardSpeed;
	private CharacterController playerMovement;

	// Use this for initialization
	void Start () {
		playerMovement = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			transform.Translate ((Vector3.forward) * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey("s")){
			transform.Translate ((Vector3.back) * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey("a")){
			transform.Translate ((Vector3.left) * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey("d")){
			transform.Translate ((Vector3.right) * moveSpeed * Time.deltaTime);
		}

		/*
		if(Input.GetKey("q")){
			transform.Rotate ((Vector3.down) * rotateSpeed * Time.deltaTime);
		}
		if(Input.GetKey("e")){
			transform.Rotate ((Vector3.up) * rotateSpeed * Time.deltaTime);
		}*/

		/*For a sprint button
		 * 	if(Input.GetKey("r")){
			moveSpeed = 20.0f;
			}
			if(!Input.GetKey("e")){
			moveSpeed = 10.0f;
			}

		//if(Input.GetKeyDown("space")){
		//	transform.Translate ((Vector3.up) * jumpSpeed * Time.deltaTime);
		}*/

	
	}
}
