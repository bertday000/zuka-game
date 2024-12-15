using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class functions : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        int jami = sum(10, 20);

        Debug.Log("jami udris: " + jami);

        float ganayofi = Div(30, 6);
        Debug.Log("ganayofi udris: " + ganayofi);

        ShowMessage("Zuka", "Shonia");

        ShowMessage1("Zuka", "Shonia", 15);
    }



    private int sum(int a, int b)
    {
        return a + b;

    }


    private float Div(int a, int b)
    {
        return a * b;
    }


    private void ShowMessage(string name, string lastname)
    {
        Debug.Log(name + " " + lastname);

    }


    private void ShowMessage1(string name1, string lastname1, int age)
    {
        Debug.Log("sruli saxelia: " + name1 + "" + lastname1 + age);
    }

}
