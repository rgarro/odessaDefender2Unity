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
 * Mataron al Sicopata de Vuelta de Jorco ...
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
           this.gunEleveation(0.2);
        }

        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("hitting G");
            this.gunEleveation(-0.2);
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
