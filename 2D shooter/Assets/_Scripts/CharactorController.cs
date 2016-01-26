using UnityEngine;
using System.Collections;

public class CharactorController : MonoBehaviour {

    private float _playInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //Public instanc variables
    public float speed = 5;

    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;

        this._playInput = Input.GetAxis("Horizontal");
        Debug.Log(this._playInput);

        if(this._playInput>0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }

        if(this._playInput<0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }

        this._checkBounds();
        
        this._transform.position = this._currentPosition;
	}

    private void _checkBounds()
    {
        if (this._currentPosition.y < -290)
        {
            this._currentPosition.y = -290;
        }

        if (this._currentPosition.y > 290)
        {
            this._currentPosition.y = 290;
        }
    }
}
