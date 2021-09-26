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


    public PlayerData (Player player)
    {
        playerName = player.playerName;
        mode = player.mode;
        character = player.character;
        gamePlay = player.gamePlay;
    }

}
