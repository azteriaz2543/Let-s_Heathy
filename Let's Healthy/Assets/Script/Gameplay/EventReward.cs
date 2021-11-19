using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventReward : MonoBehaviour
{
    Player player;

    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;

    public Text TimeText, EnegryText, HappyText, MoneyText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        EjectBotton();
    }

    // Update is called once per frame
    void Update()
    {
        if (addTimeHour <= 0)
        {
            TimeText.text = addTimeMinute.ToString() + " นาที";
        }
        else if (addTimeHour > 0)
        {
            if (addTimeMinute <= 0)
            {
                TimeText.text = addTimeHour.ToString() + " ชั่วโมง";
            }
            else if (addTimeMinute > 0)
            {
                TimeText.text = addTimeHour.ToString() + " ชั่วโมง ," + addTimeMinute.ToString() + " นาที";
            }    
        }
        
        EnegryText.text = addEnegry.ToString() + " หน่วย";
        HappyText.text = addHappy.ToString() + " หน่วย";
        MoneyText.text = addMoney.ToString() + " บาท";
    }

    public void EjectBotton()
    {
        addEnegry = Random.Range(-11,11);
        addHappy = Random.Range(-11, 11);
        addMoney = Random.Range(0, 26);

        int randomTime = Random.Range(1, 6);
        switch (randomTime)
        {
            case 1:
                addTimeHour = 0;
                addTimeMinute = 15;
                break;
            case 2:
                addTimeHour = 0;
                addTimeMinute = 30;
                break;
            case 3:
                addTimeHour = 0;
                addTimeMinute = 45;
                break;
            case 4:
                addTimeHour = 1;
                addTimeMinute = 0;
                break;
            case 5:
                addTimeHour = 1;
                addTimeMinute = 30;
                break;
        }
        
    }

    public void BackToTown()
    {
        player.enegry += addEnegry;
        player.happy += addHappy;
        player.money += addMoney;
        player.timeHour += addTimeHour;
        player.timeMinute += addTimeMinute;
        player.SavePlayer();
        SceneManager.LoadScene("Gameplay");
    }
}
