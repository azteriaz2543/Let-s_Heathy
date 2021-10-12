using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoingZoneControl : MonoBehaviour
{
    public Transform Near, Far;
    public GameObject BeatZone;

    bool isBeat;

    public GameObject FoodZone;
    bool isPlate;
    public GameObject DropZone;


    void Start()
    {
        ThrownAway();
    }

    
    void Update()
    {
        if (isBeat == true)
        {
            BeatZone.transform.position = Near.transform.position;
        }
        else
        {
            BeatZone.transform.position = Far.transform.position;
        }

        FoodZone.SetActive(isPlate);

        if (isPlate == true)
        {
            DropZone.transform.position = Near.transform.position;
        }
        else
        {
            DropZone.transform.position = Far.transform.position;
        }

    }

    public void ThrownAway()
    {
        isBeat = false;
        isPlate = false;
    }

    public void Fork()
    {
        isBeat = !isBeat;
    }

    public void Plate()
    {
        isPlate = !isPlate;
    }
}
