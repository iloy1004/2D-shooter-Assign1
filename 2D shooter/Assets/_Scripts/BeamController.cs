using UnityEngine;
using System.Collections;

public class BeamController : MonoBehaviour {

    public float speed = 8f;

    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;
 

    // Use this for initialization
    void Start () {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        this._currentPosition = this._transform.position;
        this._currentPosition = new Vector2(_currentPosition.x + speed * Time.deltaTime, _currentPosition.y);
        this._transform.position = this._currentPosition;

        if(this._transform.position.x > 441)
        {
            Destroy(gameObject);
        }
	}

    void onTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bat")
        {
            Destroy(gameObject);
        }
    }
}
