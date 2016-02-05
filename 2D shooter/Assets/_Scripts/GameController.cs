using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;

    [SerializeField]
    private AudioSource _gameOverSound;

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

            if(this._livesValue <=0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
            
        }
    }

    public int batCount=3;
    public BatContoller bat;
    public CharactorController spaceMan;
    public BonusController bonus;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public Button RestartBtn;
    

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
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        this.RestartBtn.gameObject.SetActive(false);
        //this.RestartBtn.enabled = false;

        for(int batCnt=0; batCnt < this.batCount; batCnt++)
        {
            Instantiate(bat.gameObject);
        }
    }

    private void _endGame()
    {
        this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this.RestartBtn.gameObject.SetActive(true);

        this.spaceMan.gameObject.SetActive(false);
        this.bonus.gameObject.SetActive(false);
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;

        this._gameOverSound.Play();
    }

    //public method
    public void RestartBtnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
