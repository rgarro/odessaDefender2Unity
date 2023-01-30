using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                       .-----------------TTTT_-----_______
 *                      /''''''''''(______O] ----------____  \______/]_
 *   __...---'"""\_ --''   Q                               ___________@
 *|'''                   ._   _______________=---------"""""""
 *|                ..--''|   l L |_l   |
 *|          ..--''      .  /-___j '   '
 *|    ..--''           /  ,       '   '
 *|--''                /           `    \
 *                     L__'         \    -
 *                                   -    '-.
 *                                    '.    /
 *                                      '-./
 *
 * El General Ochoa mato el unicornio azul de Silvio Rodriguez ...
 * El unicornio azul era un delfin que se robaron de un  bayou en Alabama 
 * visiones del Missisipi y louisiana dan por comer los hongos que escarban la ardillas
 * El caballo sagrado me llevo hasta Arkansas , me miro y me dijo , Ya eres un Comanche ...
 *
 *
 *@author rolando<rolando@emptyart.xyz>
 */
public class BulletTimer : MonoBehaviour {


	public int seconds_to_live;
	public float timer;

	// Use this for initialization
	void Start () {
		//Debug.Log ("tirale asere, tirale asere ...");
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1.0F * Time.deltaTime;
		//Debug.Log ("tiramos ..." + timer);
		if (timer >= seconds_to_live)
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
