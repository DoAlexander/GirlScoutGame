using UnityEngine;
using System.Collections;

public class PlayerStatistics : MonoBehaviour {
	public int maxCCookies = 3;


	public static int cookies;
	public static int maxCookies;

	// Use this for initialization
	void Start () {
		cookies = 0;
		maxCookies = maxCCookies;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
