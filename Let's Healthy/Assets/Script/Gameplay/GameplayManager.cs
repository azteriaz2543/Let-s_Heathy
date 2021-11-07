using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameplayManager : MonoBehaviour
{
    public GameObject NewDayObj;

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        StartCoroutine(DelayStart());
        StartDay();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(NewDayObj);
        }
    }

    public void StartDay()
    {
        Instantiate(NewDayObj);
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(0.01f);
        if (player.newDay == true)
        {
            player.timeHour = 6;
            player.timeMinute = 0;
            player.newDay = false;
        }
    }

}
