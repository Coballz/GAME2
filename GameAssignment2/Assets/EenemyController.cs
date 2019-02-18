﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EenemyController : MonoBehaviour
{
	public static Color friendlyColor = new Color(106, 255, 106) / 255;
	public static Color enemyColor = new Color(255, 106, 106) / 255;

 	private bool isNeutral = false;
 	private Light light;

    void Start() {
        light = GetComponent<Light>();
        MakeEnemy();
    }

    void Update() {
        
    }

    void OnCollisionEnter(Collision col) {
        if(!isNeutral && col.gameObject.tag == "HasOrb") {
            MakeNeutral();
        }
    }

    private void MakeEnemy() {
    	light.color = enemyColor;
    	isNeutral = false;
    }

    private void MakeNeutral() {
    	light.color = friendlyColor;
    	isNeutral = true;
    }
}
