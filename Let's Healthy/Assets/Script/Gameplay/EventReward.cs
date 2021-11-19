using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventReward : MonoBehaviour
{

    public string playerName;
    public int mode;
    public int character;
    public int gamePlay;

    public bool newDay;
    public int day;
    public float enegry, happy;
    public float protein, sodium, fat, kiloCaloriesl;
    public int timeHour, timeMinute;
    public int money;
    public bool save;

    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;



    // Start is called before the first frame update
    void Start()
    {
        LoadPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayer()
    {
        //SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

            playerName = data.playerName;
            mode = data.mode;
            character = data.character;
            gamePlay = data.gamePlay;
            newDay = data.newDay;
            day = data.day;
            enegry = data.enegry;
            happy = data.happy;
            protein = data.protein;
            sodium = data.sodium;
            fat = data.fat;
            kiloCaloriesl = data.kiloCaloriesl;
            timeHour = data.timeHour;
            timeMinute = data.timeMinute;
            save = data.save;
            money = data.money;


    }

    public void EjectBotton()
    {
        addEnegry += Random.Range(-11,11);
        addHappy += Random.Range(-11, 11);
        addMoney += Random.Range(0, 26);

        int randomTime = Random.Range(1, 4);
        switch (randomTime)
        {
            case 1:
                addTimeMinute = 15;
                break;
            case 2:
                addTimeMinute = 30;
                break;
            case 3:
                addTimeMinute = 45;
                break;
        }
        
    }
}
