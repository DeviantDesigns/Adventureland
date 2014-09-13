using UnityEngine;
using System.Collections;

public class HealthPlayer : Health {

	/*
	 * Start() initializes vars.
	 */
	void Start () {
		// Initialize the enemy health
		Health.health = 100f;
		Health.isDead = false;
	}
	
	/*
	 * Update() is called once per frame.
	 */
	void Update () {
	}
}
