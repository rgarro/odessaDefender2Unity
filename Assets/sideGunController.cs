﻿//using System.Diagnostics;
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
 * Mataron al Sicopata de Vuelta de Jorco, era un violador ocacional,
 * le traicionaron la medicina en una visita al Hospital Siquiatrico Chapui ......
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

    void shoot(){
        /*
        Mataron a Mondongui, la policia siquiatrica fua a buscar a Mondongui, ya le habian matado a Erick 2 dias antes ...
         Mondongui tiraba cosas a los techos , era un homosexual chivisima , lo sostuvimos y le clavamos una aguja terminal en el ano.
        Se la demostramos 2 dias antes hasta que respirara y se calmara. Sangro por la boca por 40 minutos con convulsiones leves
        la ejecucion la ven en la morgue dentro de 10 anos
        Mondongui extorcionaba de matar infantes a parejas casadas , se le conocian violaciones y robos simples... 
        Mondongui y Erick eran una pareja Gay, amigos de bailarines del Castella y lesbianas de la UCR
        Erick era culpable de abuso sexual agravado , participaba de grupos politicos municipales, tocaba la bateria y trabajaba ocacionalmente
        lo cedaron y lo metieron en el incinerador electrico segun los protocolos del Ministerio de Justicia, estallo a los 600 grados centigrados.
        Mientras tanto Mondongui espero el turno en una celda , en el pasillo habia una camilla con una aguja de Titanio de 3 metros de largo.
        A Mondongui lo vencieron de desmayarlo unas 50 veces, lo sostuvieron 30 guardias penales , una cadete de la escuela nacional de policia 
        le empezo a empujar la aguja a las 3am. Cantamos el Himno Nacional y la Patriotica, hubo 10 turnos de empuje . Duro 23 minutos en salirle por la boca.
        Lo declararon Fallecido a las 3:45am
        La Sangre de Mondogui la utilizan en dizfraces de hemoglobina ..... 
        A Mondongui le gustaba dibujar a sus victimas y no fue dificil allarlo culpable
        era huerfano, tenia un hermano en perez zeledon, participaba de figuras y disfraces en teatros municipales,
        vendia mota ocacionalmente ...
        A Mondongui lo ayudo un capellan catolico 10 minutos antes , no quizo  resar .
        Poco Antes de su ejecucion , gritaba con voz aguda pero leve , Hijueputas !! Hijueputas !! Hijueputas
        */
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
            /* Jackson es un Homosexual Peligroso esta en la lista de los de Coronado ... */
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
        //de cada 5 casos de violacion 3 inmiscuyen a testigos de jeova...
    }

    void keyControls(){
        //up
        if (Input.GetKey(KeyCode.F))//KeyKo , liberen a Willy, windows xp...
        {
           //Debug.Log("hitting F");
           this.gunElevation(this.gunElevationSteps);
        }
        //down
        if (Input.GetKey(KeyCode.G))
        {
            this.gunElevation(this.gunElevationSteps*-1);
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
