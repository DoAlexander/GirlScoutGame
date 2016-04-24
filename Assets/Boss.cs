using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	protected int health;
	protected int maxHealth = 100;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Die()
	{
		Debug.Log ("Boss Died");
		Destroy (this.gameObject);
	}

	public void TakeDamage(int amount)
	{
		health -= amount;
		Debug.Log ("Boss Health = " + health);
		if (health <= 0) {
			Die ();
		}
	}
}
