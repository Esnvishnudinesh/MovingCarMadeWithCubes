using UnityEngine;
using System.Collections;

public class strike : MonoBehaviour {
	float a = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (a >= 3.0f) {
			a = 0.1f;
		} else {a = a + 0.1f;;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Rotate (-8.0f,0.0f,0.0f);
			transform.Translate (-1.0f+a,a,0.0f);
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			transform.Rotate (-8.0f,0.0f,0.0f);
			transform.Translate (3.96f,2.3f,-15.0f);
		}
	}
}
