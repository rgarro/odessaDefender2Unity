//using System.Diagnostics;
using System.Globalization;
//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                            ______
 *         |\_______________ (_____\\______________
 * HH======#H###############H#######################
 *         ' ~""""""""""""""`##(_))#H\"""""Y########
 *                           ))    \#H\       `"Y###
 *                           "      }#H)
 * 
 * Cada dia el Imperialismo esta mas agresivo ....
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

    void shoot(){
        
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
            float elevX = this.GunCamera.transform.localEulerAngles.x + degrees;
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
        
    }

    void keyControls(){
        //up
        if (Input.GetKey(KeyCode.F))
        {
           //Debug.Log("hitting F");
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
