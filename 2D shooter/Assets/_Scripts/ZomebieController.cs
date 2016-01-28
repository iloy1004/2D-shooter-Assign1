using UnityEngine;
using System.Collections;

public class ZomebieController : MonoBehaviour {

    //Public instanc variables
    public float speed = 3f;

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
        this.speed = Random.Range(3f, 6f);

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        //Reset Zombie position
        if (this._currentPosition.x <= -463)
        {
            this.Reset();
        }
    }

    void Reset()
    {
        //float yPosition = Random.Range(-85f, 135f);
        this._transform.position = new Vector2(665f, -85f);
    }
}
