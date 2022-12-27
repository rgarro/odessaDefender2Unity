﻿using System.Globalization;
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
 * le traicionaron la medicina en una visita al Hospital Siquiatrico Chapui, los de la Cruz Roja
 * de  Curridabath le recetaron 3 punzonazos y lo dejaron en la entrada del San Juan de Dios
 * los Hijueputas del oij no lo van a recoger hasta que tenga 3 dias de muerto.
 * El Sicopata se llamaba Enrique , era un violador ocacional, Guardias Civiles Catolicos
 * de extrema derecha han vendido su homicidio.
 * Miguel Angel Rodriguez vendio 23 sentencias de Muerte, en el INCAE lo recuerdan como un genio.
 * En el 2005 un hijo de Kaddafi compro 5 sentencias en la Reforma, las agujas las enterraron en 
 * una mezquita en Tripoli y otras en Medina para que los verdugos fueran siempre inocentes.
 * Pinurber el de CostaRica Libre vio enterrar vivo a un violador en 1990. estaba a 10 metros de
 * profundidad en un contenedor EverGreen adentro habian 100 kilos de hachis que compro un primo de Kadaffi en 2002.
 * Pilo era un lider de pleito de pandillas en Santo Domingo de Heredia, lo ametrallaron en 1981,
 * Gendarmes de la policia de Guadalupe usan su hemoglobina para disfazar Pilos, algunos vigilan la entrada de una gruta religiosa en moravia.   
 * A Compix lo castro la Guardia Civil por rayar todos los puentes en la interamericana, vivio 10 dias sin su pene, tuvo un suicidio asistido en la clinica catolica.
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

    // Start is called before the first frame update
    void Start()
    {
          //Engine Sound
        this.soundPlayer = GetComponent<AudioSource> ();
           this.soundPlayer.volume = 0.2F;
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
        //if(this.checkIfGunView()){
        this.GunCamera.transform.Rotate(0,0,0);
        //}
    }

    void gunElevation(float degrees){
        //if(this.checkIfGunView()){
            float elevX = this.GunCamera.transform.localEulerAngles.x + degrees;
            this.GunCamera.transform.Rotate(elevX,0,0);
            //El Z se tiraba al piso en las borracheras fijaba un eje cartesiano contra la FANAL ..
            /* El Maestro del SubMarino dejaba peliar en el parqueo de kilates
            un dia la policia de gendarmes le mato a tebis a ross y a  varios del equipo de futbol del barrio,
            una muchacha graduada del TEC les disparo en la cien, se prepara a matar un usurpador de uniformes,
            yo le pedi que me deje matarlo con cuchillo, ella le fue a preguntar a ronny sojo. Si en el 2025 vive
            le caemos a balazos, asi dijo el Sun Solaris en Barrio Cordoba. Miguel Salguero me nombro en la DIS
            cuando sasha campbell sea presidente y yo tenga 7 palmos me da una oficina en casa presidencial
            Rigo vendia mota muy cerca de la escuela, no va a ver el 2030 el que asi se llame segun una profesora de curridabath,
            yo le recordare era un compa tuanis , una carajilla de esa escuela lo va a ultimar si sobrevive la academia alla en Madrid  ...
            A Mamey lo mataron los dominicanos
            Jackson es un Gay Peligroso esta en la lista de los de coronado
          ... */
        //}
    }

    void gunControls(){

    }

    void keyControls(){
        if (Input.GetKey(KeyCode.F))
        {
           Debug.Log("hitting F");
           this.gunElevation(0.15f);
        }

        if (Input.GetKey(KeyCode.G))
        {
            //Debug.Log("hitting G");
            this.gunElevation(-0.15f);
        }
        if (Input.GetKey(KeyCode.S))
        {
           Debug.Log("hitting S");
        }

        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("hitting X");
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.keyControls();   
    }
}
