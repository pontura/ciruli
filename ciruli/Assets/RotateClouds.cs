using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClouds : MonoBehaviour {
	
	public float rotaionSpeed;
	float speed = 0.001f;
	float suma;
	bool dilatando;
	public SpriteRenderer[] sprites;

	float colorValue = 1;
	float lastColorValue  =0;

	void Start()
	{
		sprites = GetComponentsInChildren<SpriteRenderer> ();
	}
	void Update () {
		transform.localEulerAngles = new Vector3 (0,transform.localEulerAngles.y+(rotaionSpeed*Time.deltaTime),0);
		return;

		float newColorValue = (World.Instance.intencity / 6)-0.2f;
		print (newColorValue);

		if (lastColorValue == newColorValue) return;

		lastColorValue = newColorValue;

		if (colorValue < newColorValue)
			colorValue += Time.deltaTime/4;
		else if (colorValue > newColorValue)
			colorValue -= Time.deltaTime/4;
		else
			return;

		if (colorValue < 0.1f)
			colorValue = 0.1f;
		else if (colorValue > 0.5f)
			colorValue = 0.5f;

		foreach (SpriteRenderer sr in sprites) {
			sr.color = new Color(1,1,1,colorValue);
		}
	}



	void Dilata()
	{
		suma = speed;
		dilatando = true;
	}
	void Contrae()
	{
		suma = -speed;
		dilatando = false;
	}
}
