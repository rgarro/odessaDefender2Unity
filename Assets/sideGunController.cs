//using System.Reflection.PortableExecutable;
//using System.Reflection.PortableExecutable;
using System.Diagnostics;
//using System.Diagnostics;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using Debug = UnityEngine.Debug;

/**
 *                            ______
 *         |\_______________ (_____\\______________
 * HH======#H###############H#######################
 *         ' ~""""""""""""""`##(_))#H\"""""Y########
 *                           ))    \#H\       `"Y###
 *                           "      }#H)
 * 
 * Col Kaddafi is hidding out in Macondo a Bayou in the Mobile Area
 * the sun is shinning in Sirte the weather is sweet ...
 * 
 * 
 *
 *
 *@author rolando<rolando@emptyart.xyz>
 */
public class sideGunController : MonoBehaviour
{

    public GameObject GunCamera;
    public GameObject Ammunition;
    public float ammoTimeToLive;
    private AudioSource soundPlayer;
    public AudioClip gunShotSoundClip;
    public float elevationSteps = 0.15f;
    public float rotationStepLenght = 0.3f;
    private AudioSource servoSoundPlayer;
    public AudioClip servoSoundClip;
    private bool gUP;
	private bool gDown;
    public float gunElevationSteps = 0.05f;

    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.servoSoundPlayer = GetComponent<AudioSource>();
		this.gUP = false;
		this.gDown = false;
    }

    private float radianToDegree(float angle){
		return angle * (180.0f / Mathf.PI);
	}

    void playGunShot(){
        this.soundPlayer.clip = this.gunShotSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }


    bool checkIfGunView(){
        //cameras_script = GetComponent<cameras>();
        //return !left_camera_is_hidden;
        return false;
    }

    void moveLeft(){
        if(this.checkIfGunView()){

        }
    }

    void moveRight(float degrees){
        this.GunCamera.transform.Rotate(0,0,0);
    }

    void gunElevation(float degrees){
            //float elevX = this.GunCamera.transform.localEulerAngles.x + degrees;
            float elevX = this.GunCamera.transform.rotation.x + degrees;
           // Debug.Log("elevation X: " + elevX);
            this.GunCamera.transform.Rotate(elevX,0,0);
            this.playServoSoundOn();       
    }

    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

    void gunControls(){

    }

    void shootMainGun(){
        Debug.Log("shoot shoot");
        this.playGunShot();
			//float rotX = this.GunCamera.transform.localEulerAngles.x + this.correctionAngle;
			//Quaternion rotation = Quaternion.Euler(rotX,this.turretObj.transform.eulerAngles.y,this.transform.localEulerAngles.z);
			float rotationX = this.GunCamera.transform.localEulerAngles.x;// + this.correctionAngle;
			//float elevationY = this.transform.localEulerAngles.y;
			//float elevationY = (this.transform.rotation.y-90);//this.correctionAngle;
            float elevationY = (this.GunCamera.transform.rotation.y);
Debug.Log("elevY: "+elevationY);			
			//float horizontalRotationZ = (this.turretObj.transform.localEulerAngles.z-180);
            float horizontalRotationZ = (this.GunCamera.transform.localEulerAngles.z);
Debug.Log("horizZ: " + horizontalRotationZ);	
/**		 
			Quaternion rotation = Quaternion.Euler(rotationX,elevationY,horizontalRotationZ);
			Vector3 position = new Vector3(this.turretObj.transform.position.x,this.turretObj.transform.position.y,this.turretObj.transform.position.z);
			GameObject go = (GameObject)Instantiate (this.bulletObj,position,rotation);
			Rigidbody rb =  go.GetComponent<Rigidbody>();
			rb.velocity = transform.forward * this.bulletSpeed;
        **/
    }

    void keyControls(){
        //up
        if (Input.GetKey(KeyCode.F))
        {
           this.gunElevation(this.gunElevationSteps*-1);
        }
        //down
        if (Input.GetKey(KeyCode.G))
        {
            this.gunElevation(this.gunElevationSteps);
        }
        if (Input.GetKey(KeyCode.Space))
        {
           this.shootMainGun();
        }

        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("hitting X");
        }

        if (Input.GetKeyUp (KeyCode.F) || Input.GetKeyUp(KeyCode.G)) {
			this.servoSoundPlayer.Stop ();
		}
    }

    void Update()
    {
        this.keyControls();   
    }
}
