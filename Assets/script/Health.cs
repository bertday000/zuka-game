using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] AudioSource audioScource;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] AudioClip audioClip;
    [SerializeField] enemy enemy;
    [SerializeField] CircleCollider2D col;
    [SerializeField] SpriteRenderer spriterenderer;
    [SerializeField] float health = 1f;
    Score score;

    void Start()
    {
        score = GameObject.FindWithTag("Score").GetComponent<Score>();
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
            enemy.enabled = false;
            col.enabled = false;
            spriterenderer.enabled = false;

            score.IncreaseScore();
            audioScource.PlayOneShot(explosionSound);
            Destroy(gameObject, audioClip.length);
        }


    }
}
