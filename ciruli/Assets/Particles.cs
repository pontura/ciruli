using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

	public ParticleSystem myParticles;
	private float speed = 10;
	private bool isFaster;
	private ParticleSystem.MainModule module;

	void Start()
	{
		isFaster = true;
		module = myParticles.main;
		Loop ();
	}
	void Loop()
	{
		Invoke ("Loop", Random.Range (4, 20));
		speed = Random.Range (8, 16);
		isFaster = !isFaster;
	}
	void Update()
	{
		float ss = module.simulationSpeed;
		if(isFaster)
			ss += speed * (Time.deltaTime) / 100;
		else
			ss -= speed  * (Time.deltaTime) / 100;
		if (ss > 0.5f && isFaster)
			return;
		if (ss < 0.005f && !isFaster)
			return;

		module.simulationSpeed = ss;
	}
}
