using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    public float deathDelay = 2f;

    private bool isDying = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isDying)
            return;

        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
        else if (other.CompareTag("Bullet"))
        {
            enemyHealth -= 10;
            Destroy(other.gameObject);
        }
    }

    void Death()
    {
        if (enemyHealth <= 0 && !isDying)
        {
            StartCoroutine(DeathCoroutine());
        }
    }

    IEnumerator DeathCoroutine()
    {
        isDying = true;

        Debug.Log("Enemy is dying! Dang that sucks");

        yield return new WaitForSeconds(deathDelay);

        Destroy(gameObject);
    }
}