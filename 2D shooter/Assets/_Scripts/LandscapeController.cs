using UnityEngine;
using System.Collections;

/*----------------------------------------------------------------------------
Source file name: LandscapeController.cs
Author's name: Jihee Seo
Last modified by: Jihee Seo
Last modified date: Feb 02, 2016
Program description: This program controls to landscape object as scrolling background. This background image will be scrolling during the game continually.
Revision history: 0.0 - Created document, and made movement
----------------------------------------------------------------------------*/

public class LandscapeController : MonoBehaviour {

    //Public instanc variables
    public float speed = 3;

    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        // Reset the landscape to the top
        this.Reset();

	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if(this._currentPosition.x <= -978)
        {
            this.Reset();
        }
	}

    void Reset()
    {
        this._transform.position = new Vector2(978f, 0);
    }
}
