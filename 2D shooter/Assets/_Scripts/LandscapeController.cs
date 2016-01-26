using UnityEngine;
using System.Collections;

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
