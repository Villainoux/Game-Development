using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health points.
    public int currentHealth; // Current health points.

    // This function is called when the object is created.
    void Start()
    {
        currentHealth = maxHealth; // Initialize the health to the maximum value.
    }

    // Function to decrease the health by a specified amount.
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Check if the health has dropped to or below zero.
        if (currentHealth <= 0)
        {
            Die(); // Call a function to handle the object's death.
        }
    }

    // Function to increase the health by a specified amount.
    public void Heal(int healAmount)
    {
        currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
    }

    // Function to handle the object's death.
    void Die()
    {
        // You can put your death logic here, such as destroying the object.
        Destroy(gameObject);
    }
}

