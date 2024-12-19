using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class functions : MonoBehaviour
{
    [SerializeField] float horizontalspeed = 10;
    [SerializeField] float verticalspeed = 15;


    void Update()
    {
        Move();

    }



    private void Move()
    {
        float HorizontalMovement = Input.GetAxisRaw("Horizontal");
        float VerticalMovement = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(HorizontalMovement * horizontalspeed, VerticalMovement * verticalspeed) * Time.deltaTime;



    }


}
