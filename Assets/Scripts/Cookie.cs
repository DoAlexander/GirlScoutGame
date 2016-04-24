using UnityEngine;
using System.Collections;

public class Cookie : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			DoStuff ();
			Destroy (this.gameObject);
		}
	}

	void DoStuff()
	{
		PlayerStatistics.cookies++;
		if (PlayerStatistics.cookies == PlayerStatistics.maxCookies) {
			Debug.Log ("Collected Cookies");
			LairEntrance.collectedAllCookies = true;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
