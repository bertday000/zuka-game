using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float bulletspeed = 20f;
    [SerializeField] float damage = 1f;
    [SerializeField] bool destroyOnContact;

    void Start()
    {
        rb.AddForce(transform.up * bulletspeed, ForceMode2D.Impulse);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (destroyOnContact == true)
        { Destroy(gameObject); }
        

    }

    public float GetDamage()
    {
        return damage;
    }
}
