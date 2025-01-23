using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class functions : MonoBehaviour
{

    // [SerializeField] float speed = 9.5f;
    // [SerializeField] Camera camera;
    void Start()
    {




    }

    private string firstname = "zuka";
    private string lastname = "shonia";
    private int myage = 15;
    private string myhobby = "buildin legos";

    private string Getfullname()
    {
        return firstname + " " + lastname;
    }

    private string GetFullBio()
    {
        return "my name is " + firstname + " my last name is " + lastname + " i am " + myage + " and my hobby is " + myhobby;
    }

    // void Move()
    // {
    //     float horizontal = Input.GetAxisRaw("Horizontal");
    //     float vertical = Input.GetAxisRaw("Vertical");
    //     transform.position = transform.position + new Vector3(horizontal, vertical) * Time.deltaTime * speed;
    // }

    // void Turn()
    // {
    //     Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
    //     Vector2 lookDirection = mouseWorldPosition - (Vector2)transform.position;
    //     float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
    //     transform.rotation = Quaternion.Euler(0, 0, angle);
    // }


    void Update()
    {


        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal == 1)
        {
            Debug.Log(Getfullname());
        }
        else if (horizontal == -1)
        {
            Debug.Log("i am " + myage);
        }
        else if (vertical == 1)
        {
            Debug.Log("i like playin video games");
        }
        else if (vertical == -1)
        {
            Debug.Log(GetFullBio());
        }




        // Move();
        // Turn();

        // if(Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("visvri");
        // }  

    }
}