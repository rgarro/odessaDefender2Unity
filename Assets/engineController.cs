using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * AC130 Temp Helimover ....
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

    }

    void diveRight(){

    }

    void moveForward(){
        this.AirPlane.transform.Translate(Vector3.back * (Time.deltaTime * this.yardsPerSecond));
    }
}
