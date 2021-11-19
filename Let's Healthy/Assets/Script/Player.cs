using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    #region SceneCheck
    public bool inStartScene;
    public bool inMenuScene;
    public bool inGameScene;
    public bool inMiniGameScene;
    #endregion

    #region StartScene
    public bool firstStart;
    #endregion

    #region Info
    public string playerName;
    public int mode;
    public int character;
    #endregion

    #region Data
    public int gamePlay;
    #endregion

    #region GamePlay
    public bool newDay;
    public int day;
    public float enegry, happy;
    public float protein, sodium, fat, kiloCaloriesl;
    public int timeHour,timeMinute;
    public int money;
    public bool save;
    #endregion



    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        if (firstStart == false)
        {
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
        else
        {
            firstStart = true;
        }
        
    }

    public void DeleteData()
    {
        SaveSystem.DeleteData();
    }

    void SceneCheck ()
    {
        GameObject scenechecker = GameObject.FindGameObjectWithTag("SceneChecker");
        

        if (scenechecker.name == "StartScene")
        {
            inStartScene = true;
            inMenuScene = false;
            inGameScene = false;
            inMiniGameScene = false;
        }
        else if (scenechecker.name == "MenuScene")
        {
            inStartScene = false;
            inMenuScene = true;
            inGameScene = false;
            inMiniGameScene = false;
        }
        else if (scenechecker.name == "GameScene")
        {
            inStartScene = false;
            inMenuScene = false;
            inGameScene = true;
            inMiniGameScene = false;
        }
        else if (scenechecker.name == "MiniGameScene")
        {
            inStartScene = false;
            inMenuScene = false;
            inGameScene = false;
            inMiniGameScene = true;
        }
    }

    void Start()
    {
        SceneCheck();

        if(inStartScene == true)
        {
            Start_StartScene();
        }

        if (inMenuScene == true)
        {
            Start_MenuScene();
        }

        if (inGameScene == true)
        {
            Start_GameScene();
        }

        if (inMiniGameScene == true)
        {
            Start_MiniGameScene();
        }
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(playerName + " ," +mode + " ," +character + " ," +gamePlay);
        }

        if (timeMinute >= 60)
        {
            timeHour += 1;
            timeMinute -= 60;
        }

    }

    void Start_StartScene()
    {
        LoadPlayer();

        if (firstStart == false)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void GotoMenu()
    {
        SavePlayer();
        SceneManager.LoadScene("Menu");
    }

    void Start_MenuScene()
    {
        LoadPlayer();
    }

    void Start_GameScene()
    {
        LoadPlayer();
    }

    public void ResetGameplayData()
    {
        newDay = true;
        day = 0;
        enegry = 0;
        happy = 0;
        protein = 0;
        sodium = 0;
        fat = 0;
        kiloCaloriesl = 0;
        timeHour = 0;
        timeMinute = 0;
        save = false;
    }

    void Start_MiniGameScene()
    {
        LoadPlayer();
    }

}
