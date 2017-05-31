using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

	private SpriteRenderer sr;
	bool over;

	void Start()
	{
		sr = GetComponent<SpriteRenderer> ();
	}

	public void SetCamera(Transform tr) {
		transform.LookAt (tr);	
	}
	public void OnRollOver()
	{
		over = true;
	}
	public void OnRollOut()
	{
		over = false;
	}
	void _Update()
	{
		Color c = sr.color;

		if (!over && sr.color.a > 0.4f)
			return;
		else if (!over)
			c.a += Time.deltaTime/20;
		else if(sr.color.a > 0)
			c.a -= Time.deltaTime/20;
		
		sr.color = c;
		
	}
}
