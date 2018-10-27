using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAngle: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * 30);
        }
    }
}
