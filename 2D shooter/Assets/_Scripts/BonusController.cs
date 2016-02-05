using UnityEngine;
using System.Collections;

public class BonusController : MonoBehaviour {

    //Public instanc variables
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;
    public float minHorizontalSpeed = 10f;
    public float maxHorizontalSpeed = 5f;


    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalSpeed;


    // Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        // Reset the bonus to the top
        this.Reset();

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
        float yPosition = Random.Range(30f, 140f);
        this._transform.position = new Vector2(425f, yPosition);
    }
}
