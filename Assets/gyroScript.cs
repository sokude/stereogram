using UnityEngine;
using System.Collections;

public class gyroScript: MonoBehaviour {
	
	public Transform target;	//cameraset
	// Use this for initialization
	void Start () {
		if (SystemInfo.supportsGyroscope) {
			Input.gyro.enabled = true;
		} else {
			Debug.Log ("no support gyro.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.gyro.enabled) {
			Quaternion qqq = Input.gyro.attitude;
			qqq.x *= -1;
			qqq.y *= -1;
			qqq.z *= 1;
			target.localRotation = qqq;
		}
	}
}
