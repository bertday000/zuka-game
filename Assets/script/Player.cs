using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class functions : MonoBehaviour
{
    // [SerializeField] float horizontalspeed = 15;
    // [SerializeField] float verticalspeed = 20;

    // [SerializeField] Camera camera;

    void Start()
    {
       



    }


  



    void Update()
    {

        float horizontalmovement = Input.GetAxisRaw("Horizontal");
        float verticalmovement = Input.GetAxisRaw("Vertical");

        if  (horizontalmovement == 1)
        {
            Debug.Log("hi my name is zuka");
        }
        else if (horizontalmovement == -1)
        {
            Debug.Log("my last name is shonia");
        }
        else if (verticalmovement == 1)
        {
            Debug.Log("i am 15 years old");
        }
        else if (verticalmovement == -1)
        {
            Debug.Log("my hobby is buildin legos");
        }






        //     Move();
        //     Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        //     Vector2 lookdirection = mouseWorldPosition - (Vector2)transform.position;
        //     float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        //     transform.rotation = Quaternion.Euler(0, 0, angle);
        // }

        // private void Move()
        // {
        //     float horizontalmovement = Input.GetAxisRaw("Horizontal");
        //     float verticalmovement = Input.GetAxisRaw("Vertical");
        //     transform.position += new Vector3(horizontalmovement * horizontalspeed, verticalmovement * verticalspeed, 0) * Time.deltaTime;
    }


}
