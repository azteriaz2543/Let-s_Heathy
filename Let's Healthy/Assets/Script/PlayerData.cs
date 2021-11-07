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

    public bool save;

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
    }

}
