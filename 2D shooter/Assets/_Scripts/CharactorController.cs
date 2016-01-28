using UnityEngine;
using System.Collections;

public class CharactorController : MonoBehaviour {

    private float _playInput;
    private Transform _transform;
    private Vector2 _currentPosition;

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
        this._currentPosition = this._transform.position;

        this._playInput = Input.GetAxis("Vertical");
        Debug.Log(this._playInput);

        if(this._playInput>0)
        {
            this._currentPosition += new Vector2(0, this.speed);
            sr.sprite = charactor_splite_1;
        }

        if(this._playInput<0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
            sr.sprite = charactor_splite_1;
        }

        this._checkBounds();

        this._changeCharactor();
        this._transform.position = this._currentPosition;
	}

    private void _changeCharactor()
    {
        if (this.sr.sprite == charactor_splite_1)
            this.sr.sprite = charactor_splite_0;
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
