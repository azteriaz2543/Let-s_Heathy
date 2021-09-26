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
        }
        else if (scenechecker.name == "MenuScene")
        {
            inStartScene = false;
            inMenuScene = true;
            inGameScene = false;
        }
        else if (scenechecker.name == "GameScene")
        {
            inStartScene = false;
            inMenuScene = false;
            inGameScene = true;
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
            
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(playerName + " ," +mode + " ," +character + " ," +gamePlay);
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
}
