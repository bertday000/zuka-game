using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] int hitCount = 3;
    [SerializeField] float damage = 25f;

    void OnTriggerEnter2D(Collider2D col)
    {
        hitCount = hitCount - 1;

        if (col.name == "bullet(Clone)")
        {
            Destroy(col.gameObject);
        }

        if (hitCount == 0)
        {
            Destroy(gameObject);
        }
    }

    public float Damage()
    {
        return damage;
    }
}
