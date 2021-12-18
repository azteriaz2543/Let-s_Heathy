using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoingZoneControl : MonoBehaviour
{
    public Transform Near, Far;
    public GameObject BeatZone;

    public bool isBeat;

    public GameObject FoodZone;
    bool isPlate;
    public GameObject DropZone;
    public GameObject BowlZone;

    public bool isBowl;


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

        if (isBowl == true)
        {
            BowlZone.transform.position = Near.transform.position;
        }
        else
        {
            BowlZone.transform.position = Far.transform.position;
        }

    }

    public void ThrownAway()
    {
        isBeat = false;
        isPlate = false;
        isBowl = false;
    }

    public void Fork()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Item);
        isBeat = !isBeat;
        isPlate = false;
        isBowl = false;
    }

    public void Plate()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.TableCloth);
        isPlate = !isPlate;
        isBeat = false;
        isBowl = false;
    }

    public void Bowl()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Item);
        isBowl = !isBowl;
        isBeat = false;
        isPlate = false;
    }

}
