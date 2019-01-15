using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour {
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
		
        if (Input.GetKey("up")){
			if(speed<=0.4f)
				speed=speed+0.01f;
		}
   
        //-0.9
		//0.6
		
        if (Input.GetKey("down")){
			if(speed>0.15f)
				speed=speed-0.05f;
		}
		
		if (Input.GetKey("right")){
			if(offset<=0.5f)
				offset=offset+0.1f;
		}
		
		if (Input.GetKey("left")){
			if(offset>-0.9f)
				offset=offset-0.1f;
		}
        
	}
}
