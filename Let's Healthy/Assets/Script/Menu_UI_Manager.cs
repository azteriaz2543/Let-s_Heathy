using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_UI_Manager : MonoBehaviour
{

    Player player;

    public int testday;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }


    void Update()
    {
        
    }

    #region Button
    public void Start_Button()
    {
        if (player.save == false)
        {
            player.newDay = true;
            player.day = 1;
        }
        player.SavePlayer();
        SceneManager.LoadScene("GamePlay");
    }

    public void Exit()
    {
        player.SavePlayer();
        Application.Quit();
    }

    public void Reset()
    {
        player.DeleteData();
        SceneManager.LoadScene("Start");
    }
    #endregion

}
