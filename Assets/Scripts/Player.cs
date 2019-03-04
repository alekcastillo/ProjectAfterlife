using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float mSpeed;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
	}


}
