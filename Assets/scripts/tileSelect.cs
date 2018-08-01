using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileSelect : MonoBehaviour {


	void moveTile () {
		if(Input.GetKeyDown("w")) {
			Vector3 pos = transform.position;
			pos.y += .32f;
			if (pos.y >= 2.24f) {
				pos.y = 2.24f;
			}
			transform.position = pos;
		}
		if (Input.GetKeyDown ("s")) {
			Vector3 pos = transform.position;
			pos.y -= .32f;
			if (pos.y <= 0f) {
				pos.y = 0f;
			}
			transform.position = pos;
		}
		if (Input.GetKeyDown ("a")) {
			Vector3 pos = transform.position;
			pos.x -= .32f;
			if (pos.x <= 0f) {
				pos.x = 0f;
			}
			transform.position = pos;
		}
		if (Input.GetKeyDown ("d")) {
			Vector3 pos = transform.position;
			pos.x += .32f;
			if (pos.x >= 2.24f) {
				pos.x = 2.24f;
			}
			transform.position = pos;
		}

	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		public Vector3 getCoords () {
			return transform.position;
		}
	}
}
