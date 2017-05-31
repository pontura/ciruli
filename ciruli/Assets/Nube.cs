using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour {

	public Transform nube1;
	public Transform nube2;

	private float speed1 = 100;
	private float speed2 = 100;

	void Start () {
		speed1 += Random.Range (0, 100);
		speed1 /= 4;

		speed2 += Random.Range (0, 100);
		speed2 /= 4;
	}
	public void SetCamera(Transform tr) {
		transform.LookAt (tr);	
	}
	void Update () {
		
		Vector3 rot1 = nube1.localEulerAngles;
		Vector3 rot2 = nube2.localEulerAngles;

		rot1.z += (speed1 * Time.deltaTime) * World.Instance.intencity;
		rot2.z -= (speed2 * Time.deltaTime) * World.Instance.intencity;

		nube1.localEulerAngles = rot1;
		nube2.localEulerAngles = rot2;
	}
	void OnTriggerEnter(Collider c)
	{
		foreach (LookAtCamera lac in GetComponentsInChildren<LookAtCamera>()) {
			lac.OnRollOver ();
		}
	}
	void OnTriggerExit(Collider c)
	{
		foreach (LookAtCamera lac in GetComponentsInChildren<LookAtCamera>()) {
			lac.OnRollOut ();
		}
	}
}
