using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;
    public SpriteRenderer gunDisplay;
    [SerializeField] float speedMultiplier = 1f;
    public float minShootForce = 5f;
    public float maxShootForce = 20f;
    public float chargeRate = 2f;
    private float currentShootForce;
    [SerializeField] chargeBar charge;

    private void Start()
    {
        charge = GetComponentInChildren<chargeBar>();
        gunDisplay.enabled = true;
        charge.fillImage.enabled = false;
        charge.enabled = false;
    }

    void Update()
    {
        Vector2 gunPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - gunPosition;
        transform.right = direction;
        gunDisplay.enabled = true;

        if (Input.GetMouseButtonDown(0))
        {
            gunDisplay.enabled = true;
           
        }
        if (Input.GetMouseButton(0))
        {
            charge.fillImage.enabled = true;
            currentShootForce = Mathf.Clamp(currentShootForce + chargeRate * Time.deltaTime, minShootForce, maxShootForce);
            charge.updateCharge(currentShootForce, maxShootForce);
        }

        if (Input.GetMouseButtonUp(0))
        {
            charge.fillImage.enabled = false;
            Vector3 velocity = transform.right * currentShootForce * speedMultiplier;
            gunDisplay.enabled = false;
            GameObject newBullet = Instantiate(bullet, shotPoint.position, shotPoint.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = velocity;
            
            Debug.Log(velocity + " " + currentShootForce + transform.right);
            currentShootForce = minShootForce;
        }
    }

}
