using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBoard : MonoBehaviour
{
    public GameObject CutCollider;

    public bool CanCut;

    public Transform NearCutBoard, FarCutBoard;


    void Start()
    {
        CanCut = false;
    }


    void Update()
    {
        if (CanCut == true)
        {
            CutCollider.transform.position = NearCutBoard.position;
        }
        else
        {
            CutCollider.transform.position = FarCutBoard.position;
        }
    }
}
