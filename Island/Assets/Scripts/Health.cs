using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public HealthBar healthBar;
    public int health;
    public int currentHealth;

    void Start()
    {
        currentHealth = health;
        healthBar.setMaxHealth(health);
    }

    public void TakeDamage(int damage)
    {
        healthBar.setHealth(currentHealth);

        currentHealth -= damage;

        if (currentHealth < 0)
        {
            Invoke("Destroyyy", 0f);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemytag")
        {
            TakeDamage(1);

        }
    }
    private void Destroyyy()
    {
        SceneManager.LoadScene("lost");
    }
}
