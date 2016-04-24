using UnityEngine;
using System.Collections;

public class ClickToSetDestination : MonoBehaviour {

	public GameObject raisin;
	public float fireTime = 0.5f;
	public LayerMask layerMask;

	protected NavMeshAgent nav;
	protected float currentTimer;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentTimer += Time.deltaTime;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, Mathf.Infinity, layerMask)) {
			if (Input.GetMouseButton (0)) {
			

				//Debug.DrawLine (Camera.main.ScreenToWorldPoint (Input.mousePosition), hit.point);
				nav.SetDestination (hit.point);


			}
			else if (Input.GetMouseButton (1)) {
				Vector3 fireDir = hit.point - (this.transform.position + Vector3.up);
				fireDir = fireDir.normalized;

				if (currentTimer >= fireTime) {
					currentTimer -= fireTime;
					GameObject projectile = (GameObject)Instantiate (raisin, this.transform.position + Vector3.up + fireDir, Quaternion.identity);

					projectile.GetComponent<Rigidbody> ().AddForce (fireDir * 1000);
					Destroy (projectile, 4);
				}
			}
		}
	}
}
