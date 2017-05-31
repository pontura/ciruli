using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnim : MonoBehaviour {

	private SpriteRenderer sr;
	private float _alphaValue;
	private bool isRespawning;

	void Start () {
		sr = GetComponentInChildren<SpriteRenderer> ();
		Color c = sr.color;
		c.a -= (float)Random.Range(0,100) / 100;
		sr.color = c;
	}

	void Update () {
		if (isRespawning)
			return;
		Color c = sr.color;
		if (c.a < 0) {			
			Invoke ("Repositionate", Random.Range (1, 6));
			isRespawning = true;
		} else {
			c.a -= Time.deltaTime;
			sr.color = c;
		}
	}
	void Repositionate()
	{
		float scale = (float)Random.Range (1, 100) / 100;
		sr.transform.localScale = new Vector3 (scale,scale,scale);
		Color c = sr.color;
		c.a = World.Instance.intencity/10;
		sr.color = c;
		isRespawning = false;
		Vector3 r = World.Instance.headCamera.localEulerAngles;
		if(Random.Range(0,10)>5)
			r.y += 46 + (Random.Range(0,20)-10);
		else 
			r.y -= 46 + (Random.Range(0,20)-10);
		r.x += Random.Range(0,60)-30;
		transform.localEulerAngles = r;
	}
}
