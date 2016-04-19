using UnityEngine;
using System.Collections;

public class ClickToChangeTarget : MonoBehaviour {
	public NavMeshAgent nav;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 1000)) {
				//draw invisible ray cast/vector
				Debug.DrawLine (ray.origin, hit.point);
				//log hit area to the console
				Debug.Log(hit.point);

				nav.SetDestination (hit.point);
			}
		}
	}
}
