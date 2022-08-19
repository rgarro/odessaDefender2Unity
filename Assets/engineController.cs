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
 * Se robaron un avion los narcos en argentina un dc9 frances peruana era la linea
 * Producing my Slingshot Turbine Surfkite
 * En tierras de Nayarit fue donde cayo el avion iba pa guadalajara procedente de obregon
 * Aqui cayo la paloma en la laguna de nuzco porque no pudo bajar en la pista de acapulco ..
 * En el avion de la muerte se subieron aquel dia ...
 * Los amigos de Mi Padre me admiran y me respetan en 2 y 300 metros levanto las avionetas
 * Escapaste de chicago y tambien de nuevayork aqui me llega un reporte te robaste un avion ..
 * en sanjose costarica lo tomaron prisionero ya se extendio la noticia por todo el mundo entero asi el corrido comienza del senor caro quintero
 * ruper alvarado y nelson hofman son violadores expuestos en publico ..
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

    void OnGUI(){

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

    void joystickControls(){
        if (Input.GetKey("up"))
        {
           // Debug.Log("up arrow: "+ this.helicopter.transform.eulerAngles.x);
            //this.moveForward();
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
    }
}
