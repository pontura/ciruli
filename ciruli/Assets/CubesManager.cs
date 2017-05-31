using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesManager : MonoBehaviour {

	public CubeAnim cube;
	public Transform container;
	public int total;

	void Start () {
		for (int i = 0; i < total; i++) {
			CubeAnim c= Instantiate (cube);
			c.transform.SetParent (container);
		}
	}
}
