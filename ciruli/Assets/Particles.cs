using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

	public ParticleSystem myParticles;
	public float speed = 20;
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
		Invoke ("Loop", Random.Range (3, 9));
		speed = Random.Range (12, 35);
		isFaster = !isFaster;
	}
	void Update()
	{
		float ss = module.simulationSpeed;
		if(isFaster)
			ss += speed * (Time.deltaTime) / 100;
		else
			ss -= speed  * (Time.deltaTime) / 100;
		if (ss > 0.8f && isFaster)
			return;
		if (ss < 0.2f && !isFaster)
			return;

		module.simulationSpeed = ss;
	}
}
