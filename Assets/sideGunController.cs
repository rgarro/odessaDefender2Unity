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
 * Sun is Shinning the Weather is Sweet ...
 * My Slingshot Turbine is in the UPS truck
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
        if(this.checkIfGunView()){

        }
    }

    void gunElevation(){
        if(this.checkIfGunView()){

        }
    }

    void gunControls(){

    }

    void keyControls(){
        if (Input.GetKey(KeyCode.A))
        {
           Debug.Log("hitting A");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("hitting Z");
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
