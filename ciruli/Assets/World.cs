using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

	public static World Instance;
	public Transform camera;
	public Transform headCamera;

	public float intencity;

	void Awake()
	{
		Instance = this;
	}
	void Start () {
		foreach (LookAtCamera lac in GetComponentsInChildren<LookAtCamera>()) {
			lac.SetCamera (camera);
		}
	}
}
