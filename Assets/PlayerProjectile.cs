using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public int damage = 1;

	void HitEnemy(GameObject enemy)
	{
		enemy.GetComponent<Boss> ().TakeDamage (1);
		Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			HitEnemy (other.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
