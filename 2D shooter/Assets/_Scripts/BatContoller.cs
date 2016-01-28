using UnityEngine;
using System.Collections;

public class BatContoller : MonoBehaviour {

    //Public instanc variables
    public float speed = 8f;
    public float height = 1f;

    //Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;


    // Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        // Reset the landscape to the top
        this.Reset();

    }

    // Update is called once per frame
    void Update()
    {
        this.speed = Random.Range(5f, 15f);
        this.height = Random.Range(-10f, 10f);

        Debug.Log(speed);
        Debug.Log(height);

        this._currentPosition = this._transform.position;
        this._currentPosition.x -= this.speed;
        this._currentPosition.y -= this.height;
        this._transform.position = this._currentPosition;

        //Reset Zombie position
        if (this._currentPosition.x <= -463)
        {
            this.Reset();
        }
    }

    void Reset()
    {
        
        float yPosition = Random.Range(30, 169);
        this._transform.position = new Vector2(537f, yPosition);
    }
}
