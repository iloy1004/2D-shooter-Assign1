using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public float fireRate = 0;
    public float damage = 10;
    public LayerMask whatToHit;

    private float timeToFire = 0;
    private Transform firePoint;

	// Use this for initialization
	void Start () {
	
	}
	
    void Awake()
    {
        this.firePoint = transform.FindChild("firePoint");

        if(this.firePoint == null)
        {
            Debug.LogError("No fire point?");
        }
    }

	// Update is called once per frame
	void Update () {
	    if(this.fireRate ==0)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        else
        {
            if(Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
	}

    void Shoot()
    {
        Vector2 fireDirection = new Vector2(firePoint.position.x - 100, firePoint.position.y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, fireDirection - firePointPosition, 100, whatToHit);

        if(hit.collider != null)
        {

        }
    }
}
