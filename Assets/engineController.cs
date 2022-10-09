using System.Threading;
using System;
using System.Globalization;
//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * :: AC130  Helimover ::
 *           _\ _~-\___
 *   =  = ==(____AA____D
 *               \_____\___________________,-~~~~~~~`-.._
 *               /     o O o o o o O O o o o o o o O o  |\_
 *               `~-.__        ___..----..                  )
 *                     `---~~\___________/------------`````
 *                     =  ===(_________D
 * ::: Producing my Slingshot Turbine Surfkite :::
 *    Se robaron un avion los narcos en Argentina ...
 * 
 * 
 *
 *@author Rolando<rgarro@gmail.com> 
 */
public class engineController : MonoBehaviour
{

    public GameObject heliPad;
    public GameObject heliPad2;
    public GameObject heliPad3;
    public GameObject heliPad4;
    public GameObject AirPlane;
    public float rotationSteps = 0.87f;
    public bool turnClocwise = true;
    private float helipadRotationX;
    public float yardsPerSecond = 2.0f;
    //public float engineY = 0;
    //public float engineZ = 0;
    private AudioSource soundPlayer;
    public AudioClip AirPlaneEngineSoundClip;
     public int enginePowerSliderYpos = 25;
    public int enginePowerSliderXpos = 25;
    public string engineThrottleLabel = "Engine Power";
    public float diveCurveAngleZ = 1.00f;
    public float sideDiveAccelerationRate = 2.00f;
    public float minAltitude = 3.38f;
    public float maxAltitude = 15.35f;
    public float elevationSteps = 0.05f;
    private bool isDived = false;
    private bool isDivedr = false;

    // Start is called before the first frame update
    void Start()
    {
        //this.anim = GetComponent<Animator>();
        this.helipadRotationX = this.heliPad.transform.rotation.x;

        //Engine Sound
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.playEngineSound();
    }

    // Update is called once per frame
    void Update()
    {
       this.rotateHelipad();
       this.moveForward();
       this.joystickControls();
    }

    private void rotateHelipad(){
		//this.playEngineSound();
        if(this.helipadRotationX < 359){
            this.helipadRotationX += this.rotationSteps;
        }else{
            this.helipadRotationX = 1;
        }
         this.helipadRotationX += this.rotationSteps;
		this.heliPad.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad2.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad3.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad4.transform.Rotate(0,this.helipadRotationX,0);
	}

    void OnGUI(){
         // Debug.Log("Helicopter X: "+ this.helicopter.transform.eulerAngles.x );
        GUI.Box(new Rect(this.enginePowerSliderXpos - 20,this.enginePowerSliderYpos - 15,275,30), this.engineThrottleLabel);
        this.yardsPerSecond = GUI.HorizontalSlider(new Rect(this.enginePowerSliderXpos, this.enginePowerSliderYpos, 250, 50), this.yardsPerSecond, 2.0F, 10.0F);
    }

    void playEngineSound(){
         this.soundPlayer.clip = this.AirPlaneEngineSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }

    void increaseEnginePower(){

    }

    void decreaseEnginePower(){

    }

    void diveLeft(){
        //Debug.Log("diving left");
        this.AirPlane.transform.Translate(Vector3.right * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));
        if(!this.isDived){
            this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ*-1);
            this.isDived = true;
            //Debug.Log("rotating body left "+this.isDived);
        }
    }

    void diveRight(){
        //Debug.Log("diving right");
        this.AirPlane.transform.Translate(Vector3.left * Time.deltaTime* (this.yardsPerSecond/this.sideDiveAccelerationRate));
        if(!this.isDived){
            this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ);
            this.isDived = true;
        }
    }
    void increaseEleveation(){
        if(this.AirPlane.transform.position.y < this.maxAltitude && this.AirPlane.transform.position.y > this.minAltitude){
//            this.AirPlane.transform.position.y = this.AirPlane.transform.position.y * this.elevationSteps*Time.deltaTime;
        }
    }

    void moveForward(){
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }

    void stabilizePlane(){
        this.AirPlane.transform.Rotate(0,0,0);
        this.isDived = false;
    }

    void joystickControls(){
        if (Input.GetKey("up"))
        {
           // Debug.Log("up arrow: "+ this.helicopter.transform.eulerAngles.x);
            this.increaseEleveation();
        }

        if (Input.GetKey("down"))
        {
            //Debug.Log("down arrow: " + this.helicopter.transform.eulerAngles.x);
            //this.moveBackward();
        }
         if (Input.GetKey("left")){
             this.diveLeft();
         }
        if (Input.GetKey("right")){
            this.diveRight();
         }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this.doRestart();
        }

        /*if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            Debug.Log("No Voy en Tren voy en avion ... ");
            this.stabilizePlane();
        }*/

        if (Input.GetKeyUp("left"))
        {
            //Debug.Log("left up");
            if(this.isDived){
                this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ);
                this.isDived = false;
            }
        }

        if (Input.GetKeyUp("right"))
        {
            //Debug.Log("right  up"+this.isDived);
            if(this.isDived){
                this.AirPlane.transform.Rotate(0,0,this.diveCurveAngleZ*-1);
                this.isDived = false;
            }
        }
    }
}