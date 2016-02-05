using UnityEngine;
using System.Collections;

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
