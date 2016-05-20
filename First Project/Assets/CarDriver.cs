using UnityEngine;
using System.Collections;

public class CarDriver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.forward * 5.0f * Time.deltaTime;

			if (Input.GetKey (KeyCode.LeftShift)) {
				transform.position += transform.forward * 10.0f * Time.deltaTime;
			}
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += transform.forward * -5.0f * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0.0f,-80.0f * Time.deltaTime,0.0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0.0f,80.0f * Time.deltaTime,0.0f);
		}

		if (Input.GetKey (KeyCode.R)) {
			transform.position += Vector3.up;
			transform.rotation = Quaternion.LookRotation (transform.forward,Vector3.up);
		}
	}
}
