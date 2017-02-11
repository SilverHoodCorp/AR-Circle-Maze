using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class kyleScript : MonoBehaviour {
	Animator anim;
	public GameObject respwnRobot;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//float h = Input.GetAxis ("Horizontal");
		//anim.SetFloat ("Directions", h);
		//float v = Input.GetAxis ("Vertical");
		//anim.SetFloat ("Speed", v);
		float leftright = CrossPlatformInputManager.GetAxis ("Horizontal");
		anim.SetFloat ("Directions", leftright);
		float updown = CrossPlatformInputManager.GetAxis ("Vertical");
		anim.SetFloat ("Speed", updown);

		Debug.Log ("Left Right: "+leftright+" Vert: "+updown);
		if (CrossPlatformInputManager.GetButton ("RespawnButton")) {
			transform.position = respwnRobot.transform.position;
		}
	}
}
