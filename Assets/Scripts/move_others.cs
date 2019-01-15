using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_others : MonoBehaviour {
	float cursor = 0;
	public float speed;
	public float offset;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.cursor += this.speed;

		float angle = this.cursor / 100 * 2 * Mathf.PI;

		this.transform.position = new Vector3 (
			Mathf.Cos (angle) * (32.0f + offset),
			1.25f,
			Mathf.Sin (angle) * (32.0f + offset)
		);

		this.transform.rotation = Quaternion.Euler(
			0,
			-angle / Mathf.PI * 180,
			0
		);
        
	}
}
