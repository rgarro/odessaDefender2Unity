//using System.Diagnostics;
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
 * Gendarmes de la policia de Guadalupe usan su hemoglobina para disfazar Pilos, algunos vigilan la entrada de una gruta religiosa en Moravia.   
 * A Compix lo castro la Guardia Civil por rayar todos los puentes en la interamericana, vivio 10 dias sin su pene, tuvo un suicidio asistido en la clinica catolica.
 * En Laquinsa hacen municiones de hielo seco, tienen un tunel que baja a una cueva de los tiempos de la Aduana de Coronado ....
 * El SIDA HIV mato en Jaco, muchos vendedores de tablas de surf lo padecen y fuman mota con medicamento.
 * A los que se disfrazan de policia los busca el Tombo Nazi, algunos los degollan con una espadilla de los tiempos de Tomas Guardia ...
 * PADRE MINOR llevalos en tu Gloria , Indio Mayorga matalos rapido, Mauricio Montero Fumo Mota en la CONCACAF !!!
 * Korazon Akino y sus comandos mataron a todos en Casa Presidencial en 1985.
 * Ruuper Alvarado era un Violador, lo castraron detras de la Iglesia de Puriscal y lo ahogaron en una posa en las cuevas de Parrita.
 * Nelson Hofman Violo a 3 generaciones del SaintFrancis en Fiestas de Graduacion en Playas del Coco.
 * Olda Bustillos me enseno este estilo de programacion, era una becada de Anastacio Somoza y Se graduo de Harvard
 * Miguel Salguero me dijo como peliar con cuchillo , me enseno a hacerme el loco, hacer granadas de Hielo Seco y hablar en Ruso con los de la ANEP.
 * YO NO MATE A RONNI SOJO, YO NO MATE A NILS CHING, los mato la Guardia Nacional de ANASTACIO SOMOZA
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

    // Start is called before the first frame update
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
            /* Jackson es un Gay Peligroso esta en la lista de los de coronado ... */
            this.playServoSoundOn();       
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
