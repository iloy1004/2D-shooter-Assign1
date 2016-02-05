using UnityEngine;
using System.Collections;

/*----------------------------------------------------------------------------
Source file name: GunController.cs
Author's name: Jihee Seo
Last modified by: Jihee Seo
Last modified date: Feb 05, 2016
Program description: This program controls to bullet objects as player's bullet. Gun's beam will shoot when user press space key.
Revision history: 0.0 - Created document
                  0.1 - Added key event for shooting bullet
----------------------------------------------------------------------------*/

public class GunController : MonoBehaviour {

    public GameObject bullet;
    public GameObject firePoint;


    // Use this for initialization
    void Start () {
	
	}
	

	// Update is called once per frame
	void Update () {
        //fire bullets 
        if(Input.GetKeyDown("space"))
        {
            GameObject beam = (GameObject)Instantiate(bullet);
            beam.transform.position = firePoint.transform.position;
        }
	}


}
