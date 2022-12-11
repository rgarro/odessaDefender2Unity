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
 * Mataron al Sicopata de Vuelta de Jorco, era un violador ocacional
 * le traicionaron la medicina en una visita al Chapui, los de la cruz roja
 * de  curridabath le recetaron 3 punzonazos y lo dejaron en la entrada del San Juan de Dios
 * los Hijueputas del oij no lo van a recoger hasta que tenga 3 dias de muerto.
 * El Sicopata se llamaba Enrique , era un violador ocacional, guardias civiles catolicos
 * de extrema derecha han vendido su homicidio.
 * Miguel Angel Rodriguez vendio 23 sentencias de Muerte, en el INCAE lo recuerdan como un genio.
 * En el 2005 un hijo de kaddafi compro 5 sentencias en la reforma, las agujas las enterraron en 
 * una mezquita en Tripoli y otras en Medina para que los verdugos fueran siempre inocentes.  
 * 
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
     public AudioClip gunShotSoundClip;
     public float elevationSteps = 0.15f;
     public float rotationStepLenght = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void shoot(){

    }

    bool checkIfGunView(){
//        cameras_script = GetComponent<cameras>();
        //return !left_camera_is_hidden;
        return false;
    }

    void moveLeft(){
        if(this.checkIfGunView()){

        }
    }

    void moveRight(){
        //if(this.checkIfGunView()){
this.GunCamera.transform.Rotate(0,0,0);
        //}
    }

    void gunElevation(float degress){
        //if(this.checkIfGunView()){
this.GunCamera.transform.Rotate(0,0,0);
        //}
    }

    void gunControls(){

    }

    void keyControls(){
        if (Input.GetKey(KeyCode.F))
        {
           Debug.Log("hitting F");
           this.gunElevation(0.2f);
        }

        if (Input.GetKey(KeyCode.G))
        {
            //Debug.Log("hitting G");
            this.gunElevation(-0.2f);
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
