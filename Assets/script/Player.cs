using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class functions : MonoBehaviour
{

    [SerializeField] float speed = 9.5f;
    [SerializeField] Camera camera;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject ghostbulletPrefab;

    [SerializeField] GameObject bulletSpawnPoint;

    [SerializeField] float bulletFireRateDefault = 1f;

    [SerializeField] float ghostBulletFireRateDefault = 1f;

    float ghostBulletFireRate;
    float bulletFireRate;

    private void Start()
    {
        bulletFireRate = bulletFireRateDefault;
        ghostBulletFireRate = ghostBulletFireRateDefault;
    }




    void Update()
    {

        Move();
        Turn();



        bulletFireRate -= Time.deltaTime;

        if (bulletFireRate <= 0f && Input.GetMouseButtonDown(0))
        {

            {
                Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, transform.rotation);
                bulletFireRate = bulletFireRateDefault;
            }
        }

        ghostBulletFireRate -= Time.deltaTime;

        if (ghostBulletFireRate <= 0f && Input.GetMouseButtonDown(1))
        {
            {
                Instantiate(ghostbulletPrefab, bulletSpawnPoint.transform.position, transform.rotation);
                ghostBulletFireRate = ghostBulletFireRateDefault;
            }
        }


    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(horizontal, vertical) * Time.deltaTime * speed;
    }

    void Turn()
    {
        Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mouseWorldPosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }



}