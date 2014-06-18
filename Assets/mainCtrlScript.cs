using UnityEngine;
using System.Collections;

public class mainCtrlScript : MonoBehaviour {

	public Transform l_cam, r_cam;


	bool mode = false;
	bool unitychan = false;

	// Use this for initialization
	void Start () {
		Input.compass.enabled = true;

	}

	// Update is called once per frame
	void Update () {


	}

	void OnGUI()
	{
		string modetext = mode ? "平行法へ変更" : "交差法へ変更";

		if (GUI.Button (new Rect (0, 0, 100, 40), modetext)) {
			mode = !mode;
		}
		if (mode) {
			l_cam.transform.localPosition = new Vector3 (0.1f, 0, 0);
			r_cam.transform.localPosition = new Vector3 (-0.1f, 0, 0);
		} else {
			r_cam.transform.localPosition = new Vector3 (0.1f, 0, 0);
			l_cam.transform.localPosition = new Vector3 (-0.1f, 0, 0);
		}


	}
}
