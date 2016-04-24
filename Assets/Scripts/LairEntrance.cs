using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LairEntrance : MonoBehaviour {

	public static bool collectedAllCookies;

	void OnTriggerEnter(Collider other)
	{
		if ((other.tag == "Player")&&(collectedAllCookies)) {

			//Debug.Log ("HelpMe.");
			SceneManager.LoadScene(1);

		}
		//Debug.Log ("Hello Anthony, you smell nice.");
	}

	// Use this for initialization
	void Start () {
		collectedAllCookies = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
