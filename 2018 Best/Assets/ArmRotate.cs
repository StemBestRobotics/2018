using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 30);
        }
    }
}
