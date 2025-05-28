using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    [SerializeField] float damage = 25f;

    void OnTriggerEnter2D(Collider2D col)
    {
     
    }

    public float Damage()
    {
        return damage;
    }
}
