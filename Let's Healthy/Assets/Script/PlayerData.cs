using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
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

    public int quest1, quest2, quest3, quest4, quest5, quest6;
    public bool cleal1, cleal2, cleal3, cleal4, cleal5, cleal6;

    public PlayerData (Player player)
    {
        playerName = player.playerName;
        mode = player.mode;
        character = player.character;
        gamePlay = player.gamePlay;
        newDay = player.newDay;
        day = player.day;
        enegry = player.enegry;
        happy = player.happy;
        protein = player.protein;
        sodium = player.sodium;
        fat = player.fat;
        kiloCaloriesl = player.kiloCaloriesl;
        timeHour = player.timeHour;
        timeMinute = player.timeMinute;
        save = player.save;
        money = player.money;
        quest1 = player.quest1;
        quest2 = player.quest2;
        quest3 = player.quest3;
        quest4 = player.quest4;
        quest5 = player.quest5;
        quest6 = player.quest6;
        cleal1 = player.cleal1;
        cleal2 = player.cleal2;
        cleal3 = player.cleal3;
        cleal4 = player.cleal4;
        cleal5 = player.cleal5;
        cleal6 = player.cleal6;
    }

}
