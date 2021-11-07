using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameplayManager : MonoBehaviour
{
    public GameObject NewDayObj;
    bool newDay;

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        if (player.newDay == true)
        {
            StartDay();
            player.newDay = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDay()
    {
        if (newDay == true)
        {
            Instantiate(NewDayObj);
        }
    }

}
