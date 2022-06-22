using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 **
 *
 * how selling sol beers I got a lost surfboard
 * the ukraine war on the bbc mexico city blues
 * my dodge challenger is fifteen thousand dollars away
 *
 *@author Rolando<rgarro@gmail.com> 
 */
public class engineController : MonoBehaviour
{

    public GameObject heliPad;
    public GameObject heliPad2;
    public GameObject heliPad3;
    public GameObject heliPad4;
    public float rotationSteps = 0.87f;
    public bool turnClocwise = true;
    private float helipadRotationX;
    //public float engineY = 0;
    //public float engineZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        //this.anim = GetComponent<Animator>();
        this.helipadRotationX = this.heliPad.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
       this.rotateHelipad();
    }

    private void rotateHelipad(){
		//this.playHeliEngineSoundOn();
        if(this.turnClocwise){
            //this.heliPad.transform.rotation.z += this.rotationSteps;//threejs way
            this.helipadRotationX += this.rotationSteps;
        } else {
            this.helipadRotationX -= this.rotationSteps;
        }
		this.heliPad.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad2.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad3.transform.Rotate(0,this.helipadRotationX,0);
        this.heliPad4.transform.Rotate(0,this.helipadRotationX,0);
	}

    void increaseEnginePower(){

    }

    void decreaseEnginePower(){

    }

    void diveLeft(){

    }

    void diveRight(){

    }
}
