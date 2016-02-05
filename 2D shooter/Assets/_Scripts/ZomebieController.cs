using UnityEngine;
using System.Collections;

public class ZomebieController : MonoBehaviour {

    //Public instanc variables
    public float minHorizontalSpeed = 10f;
    public float maxHorizontalSpeed = 5f;
    public GameObject explosion;
    public GameController gameController;

    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private AudioSource[] _audioSources;
    private AudioSource _bomb;

    // Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        // Reset the zombie to the top
        this.Reset();

    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition += new Vector2(this._horizontalSpeed, -104f);
        this._transform.position = this._currentPosition;

        //Reset zombie position
        if (this._currentPosition.x <= -463)
        {
            this.Reset();
        }
    }

    void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._transform.position = new Vector2(486f, -104f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.tag == "spaceMan") || (col.tag == "Beam"))
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
