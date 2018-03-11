using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {

	public string buttonName = "Jump";
	public float forceAmount = 10.0f;
	public float torqueAmount = 10.0f;
	public ForceMode forceMode;
	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (buttonName)) {
			rb.AddForce (Random.onUnitSphere * forceAmount, forceMode);
			rb.AddTorque (Random.onUnitSphere * torqueAmount, forceMode);
		}
	}
}
