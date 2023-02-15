using System.Threading;
using System.Runtime.CompilerServices;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using emptyLibUnity.UI.Util;
using UnityEngine.UI;
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
 * Colonel Kaddafi has a dacha in Providencia
 * Sheryl Crow mato a Camilo Cienfuegos
 * El Che guevara se cogio a la novia de su amigo
 * Se sintio alegre al ver su pene sercenado por agentes de la CIA quienes lo liberaron de Joto
 * Fidel Castro le nego ayuda al Che Guevara, Lo mando a morir por Joto
 * Fidel Castro era un Chilango
 * En Bolivia No Tienen Playa, el Granma no desembarco
 * who went out whoring through Colorado in myriad stolen night-cars
 * BACK WATER SWIRLING Something will never change
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
    public float topLockAngle;
    public float bottomLockAngle;

    private SimpleGaugeNeedle altitudeNeedle;
    public Image NeedleAltitude;

    //private SimpleGaugeNeedle rpmNeedle;
    //public Image NeedleRpm;

    private SimpleGaugeNeedle speedNeedle;
    public Image NeedleSpeed;

    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.servoSoundPlayer = GetComponent<AudioSource>();
		this.gUP = false;
		this.gDown = false;
        this.startDashItems();
    }

    void startDashItems(){
        this.altitudeNeedle = new SimpleGaugeNeedle();
		this.altitudeNeedle.Needle = this.NeedleAltitude;

        //this.rpmNeedle = new SimpleGaugeNeedle();
        //this.rpmNeedle.Needle = this.NeedleRpm;

         this.speedNeedle = new SimpleGaugeNeedle();
        this.speedNeedle.Needle = this.NeedleSpeed;
    }

 void setAltitude(){
		this.altitudeNeedle.getTilter(Mathf.Ceil(this.GunCamera.transform.position.y));
		this.altitudeNeedle.tiltNeedle();
	}

     /*void setEnginePower(){
		this.rpmNeedle.getTilter(this.rotationSteps);
		this.rpmNeedle.tiltNeedle();
	}*/

    void setSpeedNeedle(){
		//this.speedNeedle.getTilter(this.forwardSpeed);
		//this.speedNeedle.tiltNeedle();
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
        if(this.checkIfGunView()){}
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
        //down
        if (Input.GetKey(KeyCode.F))
        {
            if(this.GunCamera.transform.eulerAngles.x < this.bottomLockAngle){
                this.gunElevation(this.gunElevationSteps*-1);
            }
        }
        //up
        if (Input.GetKey(KeyCode.G))
        {
            if(this.GunCamera.transform.eulerAngles.x > this.topLockAngle){
                this.gunElevation(this.gunElevationSteps);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
           this.shootMainGun();
        }

        if (Input.GetKey(KeyCode.X))
        {
            //Debug.Log("hitting X");
        }

        if (Input.GetKeyUp (KeyCode.F) || Input.GetKeyUp(KeyCode.G)) {
			this.servoSoundPlayer.Stop ();
		}
    }
    void Update()
    {
        this.keyControls();
        //update gauges
        this.setAltitude();
        //this.setEnginePower();
        this.setSpeedNeedle();   
    }
}
