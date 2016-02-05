using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;

    //PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get { return _scoreValue; }
        set {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get { return _livesValue; }
        set
        {
            this._livesValue = value;
            this.LivesLabel.text = "Lives: " + this._livesValue;
        }
    }

    public int zombieCount=2;
    public ZomebieController zombie;
    public Text LivesLabel;
    public Text ScoreLabel;

	// Use this for initialization
	void Start () {
        this._initialize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;

        for(int zombieCnt=0; zombieCnt < this.zombieCount; zombieCnt++)
        {
            Instantiate(zombie.gameObject);
        }
    }
}
