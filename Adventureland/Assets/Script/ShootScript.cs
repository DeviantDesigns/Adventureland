using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

		public GameObject player;
		public GameObject bullet;
		public float bulletImpulse = 50f;
		
		// Use this for initialization
		void Start () 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			if(Input.GetButton ("left"))
			{
			Instantiate(bullet, transform.position, transform.rotation);	
			}
			if(Input.GetButton ("right"))
			{

			}
			if(Input.GetButton ("up"))
			{
				
			}
			if(Input.GetButton ("down"))
			{
				
			}
			
		}
		
	}