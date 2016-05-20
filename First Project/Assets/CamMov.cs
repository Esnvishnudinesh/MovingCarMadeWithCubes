using UnityEngine;
using System.Collections;

public class CamMov : MonoBehaviour {

	public GameObject target;
	public float offsetx,offsety,offsetz;
	public float horspeed = 2.0F;
	public float x = 0.0F;
	public float y = 0.0F;

	void Update () {

		transform.position = target.transform.position+ new Vector3(offsetx,offsety,offsetz);
		transform.LookAt (target.transform.position);
		//transform.eulerAngles=target.transform.position+ new Vector3(offsetx,offsety,offsetz);
		x = horspeed * Input.GetAxis ("Mouse X");
		//y = horspeed * Input.GetAxis ("Mouse Y");
		//float hv = horspeed * Input.GetAxis ("Mouse Z");
		transform.Rotate (0.0f,x,0.0f);
	//	transform.eulerAngles = new Vector3(y,x,0.0F);

	}
}
