using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engineController : MonoBehaviour
{

    private Animator anim;

    //private bool aIsOn = false;
    //private bool bIsOn = false;

    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e")){
            this.anim.Play("heliEngineTurn");
            //this.anim.Play("heliEngineTurnA");
            //this.anim.Play("heliEngineTurnB");
            //this.anim.Play("heliEngineTurnC");
        }
    }
}
