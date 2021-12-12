using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GymS : MonoBehaviour
{
    public GameObject game1,gameBar,panalBar,succesText,failText,panal;
    public int max = 100,checkTrue,checkFail,checkPlay;
    bool botHold, checkMax,checkMin;
    Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        game1.GetComponent<Slider>();
        game1.GetComponent<Slider>().maxValue = max;
        succesText.SetActive(false);
        failText.SetActive(false);
        panal.SetActive(false);

        EjectBotton();
    }

    // Update is called once per frame
    void Update()
    {
       //if(botHold==true)
       // {
       //     game1.GetComponent<Slider>().value += 1*Time.deltaTime;
       // }
    }
    public void a()
    {
        game1.GetComponent<Slider>().value += 1;

    }

    public void Holdbottom()
    {
        botHold = true;
        game1.GetComponent<Slider>().value = 0;
    
    }
    public void Upbottom()
    {
        botHold = false;
        print(game1.GetComponent<Slider>().value);
        //game1.GetComponent<Slider>().value = 0;
        if(game1.GetComponent<Slider>().value >= 90)
        {
            checkTrue++;
            checkPlay++;
        }
        else
        {
            checkFail++;
            checkPlay++;
        }
    }
    void FixedUpdate()
    {
        if (botHold == true)
        {
            if (game1.GetComponent<Slider>().value <= 0)
            { checkMin = true;checkMax = false; }
            if(game1.GetComponent<Slider>().value>=100)
            { checkMax = true;checkMin = false; }
            if (checkMax == true)
            {
                game1.GetComponent<Slider>().value -= 300 * Time.deltaTime;
            }
            if(checkMin==true)
            {
                game1.GetComponent<Slider>().value += 300 * Time.deltaTime;
            }
        }
        panalBar.transform.position = gameBar.transform.position;

        if(checkPlay==3)
        {

            if(checkTrue>checkFail)
            {
                succesText.SetActive(true);
                panal.SetActive(true);
                addMoney = Random.Range(15, 26);
            }
            if(checkTrue<checkFail)
            {
                failText.SetActive(true);
                panal.SetActive(true);
                addMoney = Random.Range(0, 15);
            }

            player.enegry += addEnegry;
            player.happy += addHappy;
            player.money += addMoney;
            player.timeHour += addTimeHour;
            player.timeMinute += addTimeMinute;
            player.SavePlayer();
            SceneManager.LoadScene("Gameplay");
        }
    }
    public void EjectBotton()
    {
        addEnegry = Random.Range(-11, 11);
        addHappy = Random.Range(-11, 11);
        //addMoney = Random.Range(0, 26);

        int randomTime = Random.Range(1, 6);
        switch (randomTime)
        {
            case 1:
                addTimeHour = 0;
                addTimeMinute = 15;
                break;
            case 2:
                addTimeHour = 0;
                addTimeMinute = 30;
                break;
            case 3:
                addTimeHour = 0;
                addTimeMinute = 45;
                break;
            case 4:
                addTimeHour = 1;
                addTimeMinute = 0;
                break;
            case 5:
                addTimeHour = 1;
                addTimeMinute = 30;
                break;
        }

    }
}
