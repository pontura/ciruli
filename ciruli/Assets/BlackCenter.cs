using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCenter : MonoBehaviour {

	public GameObject blackCenter;
	private Vector2 pos;

	void Start () {
		pos = new Vector2 (5, -3);
	}

	void Update () {
		float f = World.Instance.intencity / 5;
		float newZ = Mathf.Lerp (pos.x, pos.y, f);
		blackCenter.transform.localPosition = Vector3.Lerp (blackCenter.transform.localPosition, new Vector3(0,0,newZ), 0.05f);
		Vector3 actualScale = blackCenter.transform.localScale;
		float sum = 1 + (f);
		blackCenter.transform.localScale = Vector3.Lerp (actualScale, new Vector3(sum,sum,actualScale.z), 0.2f);
	}
}
