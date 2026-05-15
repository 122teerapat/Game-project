using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] public float health, maxHealth = 30f;
    public HealthBar healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<HealthBar>();
    }
    void Start()
    {
        health = maxHealth;
        healthBar.updateHealth(health, maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBar.updateHealth(health, maxHealth);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
