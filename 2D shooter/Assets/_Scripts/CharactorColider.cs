using UnityEngine;
using System.Collections;

public class CharactorColider : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _laser;
    private AudioSource _scream;
    private AudioSource _bonusSound;

    public GameController gameController;
    public BatContoller bat;
    public BonusController bonus;

    // Use this for initialization
    void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();
        //this._laser = this._audioSources[0];
        this._scream = this._audioSources[0];
        this._bonusSound = this._audioSources[1];
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bat"))
        {
            this._scream.Play();
            this.gameController.LivesValue -= 1;
            this.batReset();
        }
        
        if (other.gameObject.CompareTag("Zombie2"))
        {
            this._scream.Play();
            this.gameController.LivesValue -= 1;
        }

        if (other.gameObject.CompareTag("Bonus"))
        {
            this._bonusSound.Play();
            this.gameController.ScoreValue += 100;
            this.bonusReset();
        }
    }

    //bat's position reset
    public void batReset()
    {
        this.bat.Reset();
    }

    //bonus position reset
    public void bonusReset()
    {
        this.bonus.Reset();
    }
}
