using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBoard : MonoBehaviour
{
    public GameObject CutCollider;

    public bool CanCut;

    public Transform NearCutBoard, FarCutBoard;

    public Kitchen_UI kitchen_UI;

    void Start()
    {
        CanCut = false;

        kitchen_UI = kitchen_UI.GetComponent<Kitchen_UI>();
    }


    void Update()
    {
        if (kitchen_UI.Cuting == true)
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
    public void Cancut()
    {
            CanCut = true;
    }

    public void HideCut()
    {
            CanCut = false;

    }

}
