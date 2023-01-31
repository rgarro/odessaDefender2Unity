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
 * General Ochoa killed Silvio Rodriguez blue unicorn ...
 * blue unicorn was a bayou dolphin from Alabama who got kidnaped in a raid 
 * Eating the mushrooms squirrels dig gives you visions from louisiana and missouri
 * the sacred horse took me to Arkansas staring at me told me , Now you are a Comanche !!!
 * 
 *
 *
 *@author rolando<rolando@emptyart.xyz>
 */
public class BulletTimer : MonoBehaviour {


	public int seconds_to_live;
	public float timer;

	// Use this for initialization
	void Start () {
		//Debug.Log ("tirale asere! tirale asere! ...");
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
