using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	// Public vars
	public float health;		// Health of the player or enemy
	public bool isDead;			// True if the player or enemy is dead
	
	/*
	 * Update() is called once per frame. It updates the iDead var.
	 */
	void Update () {
		// If health is less than or equal to 0...
		if(health <= 0f && !isDead) {
			// Mark the player as dead
			isDead = true;
		}
	}

	/*
	 * TakeDamage() updates the var health according to the damage amount var.
	 */
	public void TakeDamage (float amount) {
		// Decrement the player's health by amount.
		health -= amount;
	}

	/*
	 * HealUp() updates the var health according to the healing amount var.
	 */
	public void HealUp (float amount) {
		// Increment the player's health by amount.
		health += amount;
	}
}
