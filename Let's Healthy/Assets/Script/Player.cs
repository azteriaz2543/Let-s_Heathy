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
    public bool startGame;
    #endregion

    #region GamePlay
    public bool newDay;
    public int day;
    public float enegry, happy;
    public float protein, sodium, fat, kiloCaloriesl;
    public int timeHour,timeMinute;
    public int money;
    public bool save;
    public float nephropathyHealthy, healthy;
    #endregion

    #region Quest
    public int quest1, quest2, quest3, quest4, quest5, quest6;
    public bool clear1, clear2, clear3, clear4, clear5, clear6;
    public int questSet;
    int questRandom;
    public int questClear;
    public bool passTime1, passTime2, passTime3, passNight;
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
            quest1 = data.quest1;
            quest2 = data.quest2;
            quest3 = data.quest3;
            quest4 = data.quest4;
            quest5 = data.quest5;
            quest6 = data.quest6;
            clear1 = data.clear1;
            clear2 = data.clear2;
            clear3 = data.clear3;
            clear4 = data.clear4;
            clear5 = data.clear5;
            clear6 = data.clear6;
            questSet = data.questSet;
            questClear = data.questClear;
            startGame = data.startGame;
            passTime1 = data.passTime1;
            passTime2 = data.passTime2;
            passTime3 = data.passTime3;
            passNight = data.passNight;
            nephropathyHealthy = data.nephropathyHealthy;
            healthy = data.healthy;
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
        quest1 = 0;
        quest2 = 0;
        quest3 = 0;
        quest4 = 0;
        quest5 = 0;
        quest6 = 0;
        clear1 = false;
        clear2 = false;
        clear3 = false;
        clear4 = false;
        clear5 = false;
        clear6 = false;
        questClear = 0;
    }

    void Start_MiniGameScene()
    {
        LoadPlayer();
    }

    public void ResetQuest()
    {
        questRandom = Random.Range(1, 5);
        questSet = questRandom;

        switch (questRandom)
        {
            case 1:
                quest4 = 4;
                quest5 = 5;
                quest6 = 6;
                break;
            case 2:
                quest4 = 4;
                quest5 = 5;
                quest6 = 7;
                break;
            case 3:
                quest4 = 4;
                quest5 = 6;
                quest6 = 7;
                break;
            case 4:
                quest4 = 5;
                quest5 = 6;
                quest6 = 7;
                break;
        }

        clear1 = false;
        clear2 = false;
        clear3 = false;
        clear4 = false;
        clear5 = false;
        clear6 = false;
        questClear = 0;
    }
}
