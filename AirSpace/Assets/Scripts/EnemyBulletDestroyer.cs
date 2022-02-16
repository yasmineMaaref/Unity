﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "playerBullet") {
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "enemyBullet") {
			Destroy (col.gameObject);
		}
}
}
