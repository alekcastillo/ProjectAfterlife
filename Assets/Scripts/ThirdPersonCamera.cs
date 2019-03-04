using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
	public Transform lookAt, camTransform;
	private Camera cam;
	public float distance = 10.0f;
	public float currentX = 0.0f;
	public float currentY = 0.0f;
	public float sensitivityX = 4.0f;
	public float sensitivityY = 1.0f;

	void Start() {
		camTransform = transform;
		cam = Camera.main;
	}

	void Update() {
		currentX += Input.GetAxis("Mouse X");
		currentY -= Input.GetAxis("Mouse Y");
	}
	void LateUpdate() {
		Vector3 dir = new Vector3(0, 0, -distance);
		Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt(lookAt.position);
	}
}
