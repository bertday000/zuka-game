using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 1f;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.GetComponent<Bullet>();

        if (bullet != null)
        {
            health = health - bullet.GetDamage();
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
