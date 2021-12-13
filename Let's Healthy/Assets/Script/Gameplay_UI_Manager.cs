using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gameplay_UI_Manager : MonoBehaviour
{
    Player player;

    public GameObject HouseEvent, ShopEvent, FitnessEvent, OfficeEvent, HospitalEvent, SchoolEvent,AreYouSurePanel;
    public Image CharIcon;
    public Sprite[] charImageSouce;
    public Text PlayerName;
    public GameObject Inventory;
    public string Step;
    public GameObject PlayerPanel;

    public GameObject ChooseSet;

    public Kitchen_UI kitchen_UI;
    
    public GameObject DayPanel;

    public GameObject AddTime, NextDay;
    public TMP_Text Daytext;
    public TMP_Text Timetext;

    public GameplayManager gameplayManager;

    public GetQuest getQuest;
    GameObject Quest_Panel;
    bool showQuest;
    public Text[] Quest;
    public GameObject[] Clear;
    public GameObject[] Fail;
    public Text test;

    bool endGame;
    public GameObject EndGame_Panel;
    public Text EndL1, EndL2, EndL3, EndL4, EndL5;

    int portal;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        CharIcon.sprite = charImageSouce[player.character];
        PlayerName.text = player.playerName;

        HouseEvent.SetActive(false);
        ShopEvent.SetActive(false);
        FitnessEvent.SetActive(false);
        OfficeEvent.SetActive(false);
        HospitalEvent.SetActive(false);
        SchoolEvent.SetActive(false);
        AreYouSurePanel.SetActive(false);
        Inventory.SetActive(false);

        Step = "Map";
        PlayerPanel.SetActive(true);

        ChooseSet.SetActive(false);

        kitchen_UI = kitchen_UI.GetComponent<Kitchen_UI>();

        gameplayManager = GetComponent<GameplayManager>();

        getQuest = GameObject.FindGameObjectWithTag("GetQuest").GetComponent<GetQuest>();

        showQuest = true;

        for (int i = 0;i<Clear.Length;i++)
        {
            Clear[i].SetActive(false);
            Fail[i].SetActive(false);
        }

        Quest[0].text = getQuest.GetQuestInfo(player.quest1);
        Quest[1].text = getQuest.GetQuestInfo(player.quest2);
        Quest[2].text = getQuest.GetQuestInfo(player.quest3);
        Quest[3].text = getQuest.GetQuestInfo(player.quest4);
        Quest[4].text = getQuest.GetQuestInfo(player.quest5);
        Quest[5].text = getQuest.GetQuestInfo(player.quest6);

        endGame = false;
        NextDay.SetActive(false);

        Quest_Panel = GameObject.FindGameObjectWithTag("QPanel");
    }

    // Update is called once per frame
    void Update()
    {
        DayTextUpdate();

        if (player.clear4 == true && player.clear5 == true && player.clear6 == true)
        {
            NextDay.SetActive(true);
        }
        else
        {
            NextDay.SetActive(false);
        }

        if (player.timeHour >= 24)
        {
            AddTime.SetActive(false);
        }
        else
        {
            AddTime.SetActive(true);
        }

        QuestUpdate();

        EndGameUpdate();
    }

    #region Button
    public void Menu()
    {
        AreYouSurePanel.SetActive(true);
    }

    public void Resume()
    {
        AreYouSurePanel.SetActive(false);
    }

    public void QuitWithSave()
    {
        player.save = true;
        player.SavePlayer();
        SceneManager.LoadScene("Menu");
    }

    public void QuitNoSave()
    {
        player.ResetGameplayData();
        player.SavePlayer();
        SceneManager.LoadScene("Menu");
    }

    public void House()
    {
        HouseEvent.SetActive(true);
        Inventory.SetActive(true);
        Step = "House";
        PlayerPanel.SetActive(false);
        ChooseSet.SetActive(true);
        DayPanel.SetActive(false);
        Quest_Panel.SetActive(false);
    }

    public void Back_House()
    {
        kitchen_UI.ResetKitchen();
        HouseEvent.SetActive(false);
        Inventory.SetActive(false);
        Step = "Map";
        PlayerPanel.SetActive(true);
        ChooseSet.SetActive(false);
        DayPanel.SetActive(true);
        Quest_Panel.SetActive(true);
    }
    public void Shop()
    {
        ShopEvent.SetActive(true);
        Step = "Shop";
        DayPanel.SetActive(false);
    }

    public void Back_Shop()
    {
        ShopEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    public void Fitness()
    {
        /*
        FitnessEvent.SetActive(true);
        Step = "Fitness";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                break;
            case 2:
                player.clear6 = true;
                break;
            case 3:
                player.clear6 = true;
                break;
            case 4:
                player.clear6 = true;
                break;
        }

        player.SavePlayer();
        SceneManager.LoadScene("MinigameX");
    }

    public void Back_Fitness()
    {
        /*
        FitnessEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void Office()
    {
        /*
        OfficeEvent.SetActive(true);
        Step = "Office";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                player.clear6 = true;
                break;
            case 2:
                break;
            case 3:
                player.clear5 = true;
                break;
            case 4:
                player.clear5 = true;
                break;
        }

        player.SavePlayer();    
        SceneManager.LoadScene("MiniOffi");

    }

    public void Back_Office()
    {
        /*
        OfficeEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void Hospital()
    {
        /*
        HospitalEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                player.clear4 = true;
                break;
            case 2:
                player.clear4 = true;
                break;
            case 3:
                player.clear4 = true;
                break;
            case 4:
                break;
        }

        player.SavePlayer();
        portal = Random.Range(1, 3);
        switch (portal)
        {
            case 1:
                SceneManager.LoadScene("HPTscancard");
                break;
            case 2:
                SceneManager.LoadScene("MiniHPT");
                break;
        }
    }

    public void Back_Hospital()
    {
        /*
        HospitalEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void School()
    {
        /*
        SchoolEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                player.clear5 = true;
                break;
            case 2:
                player.clear5 = true;
                break;
            case 3:
                break;
            case 4:
                player.clear4 = true;
                break;
        }

        player.SavePlayer();
        SceneManager.LoadScene("MiniSCH");
    }

    public void Back_School()
    {
        /*
        SchoolEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    #endregion

    public void AddTimeBotton()
    {
        player.timeMinute += 30;

        if (player.timeMinute >= 60)
        {
            player.timeHour++;
            player.timeMinute = 0;
        }

    }

    public void NextDayBotton()
    {
        player.ResetQuest();
        player.timeHour = 6;
        player.timeMinute = 0;
        player.day++;
        for (int i = 0; i < Clear.Length; i++)
        {
            Clear[i].SetActive(false);
            Fail[i].SetActive(false);
        }
        gameplayManager.StartDay();
    }

    void DayTextUpdate()
    {
        Daytext.text = "วันที่ " + player.day;

        if (player.timeMinute < 10)
        {
            Timetext.text = player.timeHour + ".0" + player.timeMinute + " น.";
        }
        else
        {
            Timetext.text = player.timeHour + "." + player.timeMinute + " น.";
        }
    }

    public void EventReward()
    {
        player.SavePlayer();
        SceneManager.LoadScene("EventReward");
    } 

    void QuestUpdate()
    {
        //Quest_Panel.SetActive(showQuest);

       

        if (player.clear1 == false && player.timeHour >= 8)
        {
            Fail[0].SetActive(true);
            Clear[0].SetActive(false);
        }
        else if (player.clear1 == true)
        {
            Clear[0].SetActive(true);
            Fail[0].SetActive(false);
        }

        if (player.clear2 == false && player.timeHour >= 14)
        {
            Fail[1].SetActive(true);
            Clear[1].SetActive(false);
        }
        else if (player.clear2 == true)
        {
            Clear[1].SetActive(true);
            Fail[1].SetActive(false);
        }

        if (player.clear3 == false && player.timeHour >= 20)
        {
            Fail[2].SetActive(true);
            Clear[2].SetActive(false);
        }
        else if (player.clear3 == true)
        {
            Clear[2].SetActive(true);
            Fail[2].SetActive(false);
        }

        if (player.clear4 == true)
        {
            Clear[3].SetActive(true);
            Fail[3].SetActive(false);
        }

        if (player.clear5 == true)
        {
            Clear[4].SetActive(true);
            Fail[4].SetActive(false);
        }

        if (player.clear6 == true)
        {
            Clear[5].SetActive(true);
            Fail[5].SetActive(false);
        }

    }

    public void QuestBotton()
    {
        showQuest = !showQuest;
    }

    void EndGameUpdate()
    {
        if (player.day >= 7)
        {
            endGame = true;
        }

        EndGame_Panel.SetActive(endGame);

        EndL1.text = "ปริมาณโซเดียม : " + player.sodium.ToString() + " กรัม";
        EndL2.text = "ปริมาณไขมัน : " + player.fat.ToString() + " กรัม";
        EndL3.text = "ปริมาณโปรตีน : " + player.protein.ToString() + " กรัม";
        EndL4.text = "ปริมาณคอลลอรี่ : " + player.kiloCaloriesl.ToString() + " กิโลแคลอรี่";
        EndL5.text = "ค่าความสุข : " + player.happy.ToString() + " หน่วย";
    }

    public void NextEndGame()
    {
        QuitNoSave();
    }

}
