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
    public Text EndL1, EndL2, EndL3, EndL4, EndL5, EndL6, EndL7;

    int portal;
    public float timer;

    public GameObject HowToPlay;
    public Image HowToPlayImage;
    public Sprite [] HowToPlayStep;
    int nowHTPI;
    public GameObject HowToPlayBackB;

    public GameObject soundGameObject;
    AudioSource audioSource;
    public AudioClip kitchenBGM;

    bool inKitchen;
    

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


        nowHTPI = 0;

        if (player.startGame == true)
        {
            HowToPlay.SetActive(true); 
            player.startGame = false;
        }
        else
        {
            HowToPlay.SetActive(false);
        }

        audioSource = soundGameObject.GetComponent<AudioSource>();

        inKitchen = false;


    }

    // Update is called once per frame
    void Update()
    {
        DayTextUpdate();

        if (player.questClear >= 2 && player.timeHour >= 18)
        {
            NextDay.SetActive(true);
        }
        else
        {
            NextDay.SetActive(false);
        }

        if (player.timeHour == 23 && player.timeMinute == 30)
        {
            if (player.passNight == false)
            {
                player.passNight = true;
                Sound_Manager.PlaySound(Sound_Manager.Sound.Clock);
            }
            
        }

        if (player.timeHour >= 24)
        {
            NextDayBotton();
        }

        QuestUpdate();

        EndGameUpdate();

        HowToPlayImage.sprite = HowToPlayStep[nowHTPI];
        
        if (nowHTPI <= 0)
        {
            HowToPlayBackB.SetActive(false);
        }
        else
        {
            HowToPlayBackB.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        if (inKitchen == false)
        {
            timer += Time.deltaTime;
            if (timer > 0.5f)
            {
                player.timeMinute += 1;
                timer = 0;
            }
        }
            
    
    }

    #region Button
    public void Menu()
    {
        AreYouSurePanel.SetActive(true);
        Time.timeScale = 0;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
    }

    public void Resume()
    {
        AreYouSurePanel.SetActive(false);
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
    }

    public void QuitWithSave()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        player.save = true;
        player.SavePlayer();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void QuitNoSave()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        player.ResetGameplayData();
        player.SavePlayer();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void House()
    {
        inKitchen = true;
        audioSource.clip = kitchenBGM;
        audioSource.Play();
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Time.timeScale = 1;
        player.SavePlayer();
        SceneManager.LoadScene("Gameplay");

        /*
        kitchen_UI.ResetKitchen();
        HouseEvent.SetActive(false);
        Inventory.SetActive(false);
        Step = "Map";
        PlayerPanel.SetActive(true);
        ChooseSet.SetActive(false);
        DayPanel.SetActive(true);
        Quest_Panel.SetActive(true);
        */
    }
    public void Shop()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        ShopEvent.SetActive(true);
        Step = "Shop";
        DayPanel.SetActive(false);
    }

    public void Back_Shop()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        ShopEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    public void Fitness()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
                if (player.clear6 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear6 = true;
                    player.questClear += 1;
                }
                break;
            case 3:
                if (player.clear6 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear6 = true;
                    player.questClear += 1;
                }
                break;
            case 4:
                if (player.clear6 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear6 = true;
                    player.questClear += 1;
                }
                break;
        }

        player.SavePlayer();
        SceneManager.LoadScene("MinigameX");
    }

    public void Back_Fitness()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        FitnessEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void Office()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        OfficeEvent.SetActive(true);
        Step = "Office";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                if (player.clear6 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear6 = true;
                    player.questClear += 1;
                }
                break;
            case 2:
                break;
            case 3:
                if (player.clear5 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear5 = true;
                    player.questClear += 1;
                }
                break;
            case 4:
                if (player.clear5 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear5 = true;
                    player.questClear += 1;
                }
                break;
        }

        player.SavePlayer();    
        SceneManager.LoadScene("MiniOffi");

    }

    public void Back_Office()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        OfficeEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void Hospital()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        HospitalEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                if (player.clear4 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear4 = true;
                    player.questClear += 1;
                }
                break;
            case 2:
                if (player.clear4 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear4 = true;
                    player.questClear += 1;
                }
                break;
            case 3:
                if (player.clear4 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear4 = true;
                    player.questClear += 1;
                }
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
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        HospitalEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    public void School()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        SchoolEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
        */

        switch (player.questSet)
        {
            case 1:
                if (player.clear5 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear5 = true;
                    player.questClear += 1;
                }
                break;
            case 2:
                if (player.clear5 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear5 = true;
                    player.questClear += 1;
                }
                break;
            case 3:
                break;
            case 4:
                if (player.clear4 == false)
                {
                    Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
                    player.clear4 = true;
                    player.questClear += 1;
                }
                break;
        }

        player.SavePlayer();
        SceneManager.LoadScene("MiniSCH");
    }

    public void Back_School()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        /*
        SchoolEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
        */
    }
    #endregion

    public void AddTimeBotton()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        player.timeMinute += 60;
    }

    public void NextDayBotton()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);

        if (player.clear1 == false)
        {
            player.healthy += 50;
            player.nephropathyHealthy += 50;
            player.happy-= 25;
        }
        if (player.clear2 == false)
        {
            player.healthy += 50;
            player.nephropathyHealthy += 50;
            player.happy -= 25;
        }
        if (player.clear3 == false)
        {
            player.healthy += 50;
            player.nephropathyHealthy += 50;
            player.happy -= 25;
        }
        if (player.clear4 == false)
        {
            //หักเงิน
        }
        if (player.clear5 == false)
        {
            //หักเงิน
        }
        if (player.clear6 == false)
        {
            //หักเงิน
        }

        player.ResetQuest();
        player.timeHour = 6;
        player.timeMinute = 0;
        player.day++;
        for (int i = 0; i < Clear.Length; i++)
        {
            Clear[i].SetActive(false);
            Fail[i].SetActive(false);
        }
        player.passTime1 = false;
        player.passTime2 = false;
        player.passTime3 = false;
        player.passNight = false;
        player.SavePlayer();
        SceneManager.LoadScene("Gameplay");
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

            if (player.passTime1 == false)
            {
                player.passTime1 = true;
                Sound_Manager.PlaySound(Sound_Manager.Sound.MissionFail);
            }

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

            if (player.passTime2 == false)
            {
                player.passTime2 = true;
                Sound_Manager.PlaySound(Sound_Manager.Sound.MissionFail);
            }
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

            if (player.passTime3 == false)
            {
                player.passTime3 = true;
                Sound_Manager.PlaySound(Sound_Manager.Sound.MissionFail);
            }
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
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        showQuest = !showQuest;
    }

    float HappyTemp;
    float HealthyTemp;

    void EndGameUpdate()
    {
        if (player.day >= 8)
        {
            endGame = true;
        }

        EndGame_Panel.SetActive(endGame);

        EndL1.text = "ปริมาณโซเดียม : " + player.sodium.ToString() + " กรัม";
        EndL2.text = "ปริมาณไขมัน : " + player.fat.ToString() + " กรัม";
        EndL3.text = "ปริมาณโปรตีน : " + player.protein.ToString() + " กรัม";
        EndL4.text = "ปริมาณคอลลอรี่ : " + player.kiloCaloriesl.ToString() + " กิโลแคลอรี่";
        HappyTemp = player.happy / 10;
        EndL5.text = "ค่าความสุข : " + HappyTemp.ToString() + " หน่วย";
        if (player.mode == 0)
        {
            EndL6.text = "ค่าสุขภาพ : " + player.healthy.ToString() + " หน่วย";
            HealthyTemp = player.healthy;
        }
        else if (player.mode == 1)
        {
            EndL6.text = "ค่าสุขภาพ : " + player.nephropathyHealthy.ToString() + " หน่วย";
            HealthyTemp = player.nephropathyHealthy;
        }

        if (HealthyTemp <= 0)
        {
            HealthyTemp = 0;
            EndL7.text = "ดีมาก คุณควบควมอาหารได้ดีมาตลอดทั้งสัปดาห์เลย";
        }
        else if (HealthyTemp > 0 && HealthyTemp <= 525)
        {
            EndL7.text = "คุณต้องเพิ่มความระมัดระวังขึ้นอีก ต้องลดการปรุงบางอย่างลงบ้างแล้ว";
        }
        else if (HealthyTemp > 525 && HealthyTemp <= 1575)
        {
            EndL7.text = "คุณรับประทานอาหารที่อันตรายไปมากแล้ว ต้องปรับปรุงตัวโดยด่วน";
        }
        else if (HealthyTemp > 1575)
        {
            EndL7.text = "คุณควรเข้ารับคำปรึกษาจากแพทย์โดยด่วน";
        }


    }

    public void NextEndGame()
    {
        QuitNoSave();
    }

    public void HowToPlayButton()
    {
        Time.timeScale = 0;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        nowHTPI = 0;
        HowToPlay.SetActive(true);
    }

    public void HowToPlayClose()
    {
        Time.timeScale = 1;
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        nowHTPI = 0;
        HowToPlay.SetActive(false);
    }

    public void HowToPlayNext()
    {
        if (nowHTPI >= 7)
        {
            Time.timeScale = 1;
            HowToPlayClose();
        }
        else
        {
            Time.timeScale = 0;
            nowHTPI++;
        }
    }

    public void HowToPlayBack()
    {
            nowHTPI--;
    }

}
