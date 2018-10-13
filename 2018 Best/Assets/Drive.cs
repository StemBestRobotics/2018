using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * 1 * Time.deltaTime;
        }
    }
}
