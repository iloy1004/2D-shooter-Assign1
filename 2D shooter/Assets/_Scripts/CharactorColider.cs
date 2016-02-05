using UnityEngine;
using System.Collections;

public class CharactorColider : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _laser;
    private AudioSource _scream;
    public GameController gameController;
    // Use this for initialization
    void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();
        //this._laser = this._audioSources[0];
        this._scream = this._audioSources[0];
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bat"))
        {
            this._scream.Play();
            this.gameController.LivesValue -= 100;
        }
        if (other.gameObject.CompareTag("Zombie2"))
        {
            this._scream.Play();
            this.gameController.LivesValue -= 100;
        }

    }
}
