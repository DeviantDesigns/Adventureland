using UnityEngine;
using System.Collections;

public class HealthEnemy : Health {

	/*
	 * Start() initializes vars.
	 */
	void Start () {
		// Initialize the enemy health
		Health.health = 50f;
		Health.isDead = false;
	}
	
	/*
	 * Update() is called once per frame.
	 */
	void Update () {
	}
}
