using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AirConTrol : MonoBehaviour
{
    int airNumber, aircouter,coutdown;
    public Text airNumtext, aircoutext;
    Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        startgame();
        EjectBotton();
    }

    // Update is called once per frame
    void Update()
    {
        airNumtext.text = airNumber.ToString();
        aircoutext.text = aircouter.ToString();
        if(coutdown==3)
        {
            player.enegry += addEnegry;
            player.happy += addHappy;
            player.money += addMoney;
            player.timeHour += addTimeHour;
            player.timeMinute += addTimeMinute;
            player.SavePlayer();
            SceneManager.LoadScene("Gameplay");
        }
        if (aircouter==airNumber)
        {
            coutdown += 1;
            startgame();
        }
    }

    public void Addaircout()
    {
        aircouter += 1;
    }
    public void Negetaircout()
    {
        aircouter -= 1;
    }

    void startgame()
    {
        airNumber = Random.Range(16, 33);
        print(airNumber);
        aircouter = Random.Range(1, 40);
        if (aircouter == airNumber)
        {
            int airRand = Random.Range(1, 3);
            switch (airRand)
            {
                case 1:
                    aircouter += Random.Range(1, 11);
                    break;
                case 2:
                    aircouter -= Random.Range(1, 11);
                    break;
            }
        }
    }
    public void EjectBotton()
    {
        addEnegry = Random.Range(-11, 11);
        addHappy = Random.Range(-11, 11);
        addMoney = Random.Range(0, 26);

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
