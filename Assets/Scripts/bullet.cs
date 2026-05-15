using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject impaceEffect;
    bool hasHit;
    public float damage = 1;
    public float splashRange = 0.25f;
    public turnController turnControllerInstance;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        turnControllerInstance = FindObjectOfType<turnController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        
        GameObject effect = Instantiate(impaceEffect, transform.position, Quaternion.identity);
        if (splashRange > 0)
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, splashRange);
            foreach (var hitCollider in hitColliders)
            {
                var player = hitCollider.GetComponent<playerHealth>();
                if (player)
                {
                    var closestPoint = hitCollider.ClosestPoint(transform.position);
                    var distannce = Vector3.Distance(closestPoint, transform.position);

                    var damagePercent = Mathf.InverseLerp(splashRange, 0, distannce);
                    player.TakeDamage(damagePercent * damage);
                    Debug.Log("splash " + damagePercent);
                    Destroy(gameObject, 0.05f);
                }
            }
        }
        else
        {
            if (collision.gameObject.TryGetComponent<playerHealth>(out playerHealth playerComponent))
            {
                playerComponent.TakeDamage(damage);

            }
        }

        turnControllerInstance.SwitchPlayer();
        Destroy(effect, 0.5f);

    }

   
}