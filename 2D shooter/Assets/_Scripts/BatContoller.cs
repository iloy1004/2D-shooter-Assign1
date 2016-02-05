using UnityEngine;
using System.Collections;

/*----------------------------------------------------------------------------
Source file name: BatController.cs
Author's name: Jihee Seo
Last modified by: Jihee Seo
Last modified date: Feb 05, 2016
Program description: This program controls to bat objects as player's enemies. Bat object will destroy when meet player or gun's beam.
Revision history: 0.0 - Created document, and made basic methods, Start and Update()
                  0.1 - Added reset method
                  1.0 - Added Trigger Event for destruction
                  1.1 - Added animation of explosion
----------------------------------------------------------------------------*/

public class BatContoller : MonoBehaviour {

    //Public instanc variables
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;
    public float minHorizontalSpeed = 10f;
    public float maxHorizontalSpeed = 5f;
    public GameObject explosion;
    public GameController gameController;

    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalSpeed;
    private AudioSource[] _audioSources;
    private AudioSource _bomb;

    // Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        // Reset the bat to the top
        this.Reset();

        this._audioSources = gameObject.GetComponents<AudioSource>();
        //this._laser = this._audioSources[0];
        this._bomb = this._audioSources[0];
    }

    // Update is called once per frame
    void Update()
    {
        
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalSpeed);
        this._transform.position = this._currentPosition;

        //Reset Bat position
        if (this._currentPosition.x <= -463)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(30f, 169f);
        this._transform.position = new Vector2(537f, yPosition);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if((col.tag == "spaceMan")|| (col.tag == "Beam"))
        {
            playExplosion();
            this._bomb.Play();
            this.gameController.ScoreValue += 200;
            //Destroy(gameObject);
            this.Reset();
        }
    }

    void playExplosion()
    {
        GameObject explosionObj = (GameObject)Instantiate(explosion);
        explosionObj.transform.position = this._transform.position;
    }
}
