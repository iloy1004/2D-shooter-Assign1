using UnityEngine;
using System.Collections;

public class CharactorController : MonoBehaviour {

    private float _playInput_y;
    private float _playInput_x;
    private Transform _transform;
    private float _currentPosition_y;
    private float _currentPosition_x;

    //Public instanc variables
    public float speed = 5f;
    public Sprite charactor_splite_0;
    public Sprite charactor_splite_1;
    public SpriteRenderer sr;
    


    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.sr = gameObject.GetComponent<SpriteRenderer>();

        sr.sprite = charactor_splite_0;
    }
	
	// Update is called once per frame
	void Update () {
        this._currentPosition_x = this._transform.position.x;
        this._currentPosition_y = this._transform.position.y;

        this._playInput_y = Input.GetAxis("Vertical");
        this._playInput_x = Input.GetAxis("Horizontal");


        //move position and check bounds
        this._changePosition();
        this._checkBounds();
        
        //this._changeCharactor();
        this._transform.position = new Vector2 (this._currentPosition_x, this._currentPosition_y);

  
    }

    private void _changeCharactor()
    {
        if (this.sr.sprite == charactor_splite_1)
            this.sr.sprite = charactor_splite_0;
    }

    private void _checkBounds()
    {
        if (this._currentPosition_y < -290f)
        {
            this._currentPosition_y = -290f;
        }

        if (this._currentPosition_y > 290f)
        {
            this._currentPosition_y = 290f;
        }
    }

    private void _changePosition()
    {
        if (this._playInput_y > 0)
        {
            this._currentPosition_y += this.speed;
            sr.sprite = charactor_splite_1;
        }
        if (this._playInput_y < 0)
        {
            this._currentPosition_y -= this.speed;
            sr.sprite = charactor_splite_1;
        }

        if (this._playInput_x > 0)
        {
            this._currentPosition_x += this.speed;
            sr.sprite = charactor_splite_1;
        }
        if (this._playInput_x < 0)
        {
            this._currentPosition_x -= this.speed;
            sr.sprite = charactor_splite_1;
        }
    }
}
