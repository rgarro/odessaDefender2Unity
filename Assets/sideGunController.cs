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
 *  La Cienciologia es Una Secta Gay
 * El SIDA afecta la promiscuidad, pero
 * deshacerce de los gays recatados necesita 
 * de una trampa religiosa. EL SARS y la nanotecnologia
 * provocaran el siguiente genocidio gay. Sigourney Weaver
 * queria vender el planeta a razas comedoras de humanos
 * pero la peste gay hace la carne invendible.
 * Los Colores de la Libertad Gay provocan apetito entre los depredadores, aliens, chupacabras y rigelianos,
 * pero despues de morder un gay piden reembolso en sus bancos provovando la quiebra de Monsanto.
 * El Coronel Kaddafi esta en Macondo, un rigeliano le pregunta , coronel que vamos a comer hoy?
 * El Coronel le contesta iracundo, Mierda !! , no me han pagado los maricas que vaporizaron el mes pasado !!.....
 * ALAbama ALAbama , Macondo esta en un bayou cerca de Mobile, los primos del profeta salvaran el planeta
 * vendiendo los gays, como lo hicieron en Andalusia hace 9 siglos.
 * Garcia Marquez era Gay , los catolicos colombianos le seguian la corriente, no volveria a nacer segun
 * los concilios romanos de la santa inquisicion, Pero se podria vender a un chupacabras y usar los fondos
 * para liberar jerusalem, la guerra en siria no acaba, la venta de carne gay la financia.
 *
 * Los Gays son Bravos, esto le gusta a los depredadores y a los aliens, para lucharlos un poco
 * antes de adobarlos con acido carbonico.
 * Los Aliens evitan ser Gays naciendo de huevos incrustados en lesbianas europeas, coronel kaddafi
 * y sus ministros invirtieron en el Euro y en discotecas por todo el mediterraneo donde los Aliens 
 * se aparean. Cojones Cojones gritaban traficantes de Gays en fuertevetura, en media fiesta rave, 
 * se comen dos lesbianas y tres peluqueros brasileiros.
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
        cameras_script = GetComponent<cameras>();
        return !left_camera_is_hidden;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
