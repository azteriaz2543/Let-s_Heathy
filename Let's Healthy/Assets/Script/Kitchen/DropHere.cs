using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHere : MonoBehaviour
{
    public GameObject DropHereGO,DropHereGO2;

    public Transform Near, Far;


    void Start()
    {

    }


    void Update()
    {

    }

    public void Stove()
    {

            DropHereGO.transform.position = Near.position;
            DropHereGO2.transform.position = Far.position;

    }

    public void Counter()
    {

            DropHereGO.transform.position = Far.position;
            DropHereGO2.transform.position = Near.position;

    }

    public void NoDrop()
    {
        DropHereGO.transform.position = Far.position;
        DropHereGO2.transform.position = Far.position;
    }

}
