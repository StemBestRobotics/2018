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

    public bool clawRotateCheck = true;
    public bool clawRotateToggle = true;
    public float clawRotateValue = 0;

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
        if (Input.GetAxis("robotClawRotate") > 0 && clawRotateCheck) {
            if (clawRotateToggle == true){
                if (clawRotateValue < 90) {
                    robotClawBase.transform.Rotate(0, 10 * Time.deltaTime, 0);
                    clawRotateValue += 10 * Time.deltaTime;
                } else {
                    clawRotateToggle = false;
                    clawRotateCheck = true;
                }
            } else {
                if (clawRotateValue > 0)
                {
                    robotClawBase.transform.Rotate(0, -10 * Time.deltaTime, 0);
                    clawRotateValue -= 10 * Time.deltaTime;
                }
                else
                {
                    clawRotateToggle = true;
                    clawRotateCheck = true;
                }
            }
        }
        robotClawWrist.transform.Rotate(0, 0, Input.GetAxis("robotClawAngle") * Time.deltaTime * speed);
        robotClawGrab.transform.Rotate(0, 0, Input.GetAxis("robotClawGrab") * Time.deltaTime * speed );
        Debug.Log(clawRotateValue);
        Debug.Log(Input.GetAxis("robotClawRotate"));
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
