using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHere : MonoBehaviour
{
    public GameObject DropHereGO;

    public Transform Near, Far;


    void Start()
    {
        DropHereGO.transform.position = Far.position;
    }


    void Update()
    {

    }

    public void Stove()
    {

      DropHereGO.transform.position = Near.position;

    }

    public void NoDrop()
    {
        DropHereGO.transform.position = Far.position;

    }

}
