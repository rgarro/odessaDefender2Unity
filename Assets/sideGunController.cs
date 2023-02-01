using System.Runtime.CompilerServices;
using System;
using System.Diagnostics;
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
 * Colonel Kaddafi is hidding out in Macondo ...
 * EverGreen is somewhere in Alabama
 * My Lawyer was 15 minutes earlier when I was 15 minutes earlier ...
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
    public float bulletSpeed = 75;
	public float correctionAngle = 90;

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
            float elevX = this.GunCamera.transform.rotation.x + degrees;
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
        this.playGunShot();
		float rotationX = this.GunCamera.transform.eulerAngles.x;
        float elevationY = this.GunCamera.transform.eulerAngles.y;
        float horizontalRotationZ = this.GunCamera.transform.eulerAngles.z;
		Quaternion rotation = Quaternion.Euler(rotationX,elevationY,horizontalRotationZ);
		Vector3 position = new Vector3(this.GunCamera.transform.position.x,this.GunCamera.transform.position.y,this.GunCamera.transform.position.z);//Me veras caer como una flecha salvaje
		GameObject go = (GameObject)Instantiate (this.Ammunition,position,rotation);
		Rigidbody rb =  go.GetComponent<Rigidbody>();
		rb.velocity = (this.GunCamera.transform.forward * -1) * this.bulletSpeed;//Hang em out clint eastwood ....
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
