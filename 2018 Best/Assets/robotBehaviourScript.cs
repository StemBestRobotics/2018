using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotBehaviourScript : MonoBehaviour {
    public GameObject robotArm;
    public GameObject robotArmHousing;
    public GameObject robotArmExtension;
    public GameObject robotArmTelescope;
    public GameObject robotClawBase;
    public GameObject robotClawWrist;
    public GameObject robotClawGrab;

    public float speed = 50;
    public float speedtest = 0.5f;

    // Use this for initialization
    void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += new Vector3(Input.GetAxis("robotMovement") * Time.deltaTime * speed * 0.04f, 0,0);
        robotArm.transform.Rotate(0, Input.GetAxis("robotArmRotate") * Time.deltaTime * speed * 0.5f, 0);
        robotArmHousing.transform.Rotate(0,0,Input.GetAxis("robotArmAngle") * Time.deltaTime * speed * 0.4f);
        robotArmExtension.transform.localPosition += new Vector3(Input.GetAxis("robotArmExtension") * Time.deltaTime * speed * 0.04f, 0, 0);
        robotArmTelescope.transform.localPosition += new Vector3(Input.GetAxis("robotArmExtension") * Time.deltaTime * speed * 0.04f, 0, 0);
        robotClawBase.transform.Rotate(0, Input.GetAxis("robotClawRotate") * Time.deltaTime * speed, 0);
        robotClawWrist.transform.Rotate(0, 0, Input.GetAxis("robotClawAngle") * Time.deltaTime * speed);
        robotClawGrab.transform.Rotate(0, 0, Input.GetAxis("robotClawGrab") * Time.deltaTime * speed );
        /*
        if (Input.GetKey(KeyCode.D))
        {
            robotArm.transform.Rotate(Vector3.up * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.A))
        {
            robotArm.transform.Rotate(Vector3.down * Time.deltaTime * 30);
        }
        */
    }
}
