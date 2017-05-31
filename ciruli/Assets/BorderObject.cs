using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderObject : MonoBehaviour {

	public Transform camera;

	public SpriteRenderer[] sprites;
	public bool isLeft;
	float speed = 0.01f;

	void Start () {
		//sprites = GetComponentsInChildren<SpriteRenderer> ();
	}

	float colorValue = 1;

	void Update () {
		
		transform.rotation = Quaternion.Lerp (transform.rotation, camera.rotation, 0.05f);

		float newColorValue = World.Instance.intencity / 2;

		if (colorValue == newColorValue) return;

		if (colorValue < newColorValue)
			colorValue += speed;
		else
			colorValue -= speed;
		
		foreach (SpriteRenderer sr in sprites) {
			sr.color = new Color(colorValue, 0.7f, 0,colorValue);
		}
	}
}
