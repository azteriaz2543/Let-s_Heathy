using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cardscan : MonoBehaviour
{
    int check;
    public GameObject panal,text;
    Player player;
    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        panal.SetActive(false);
        text.SetActive(false);
        EjectBotton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("sus");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        check++;
        if (check==60)
        {
            text.SetActive(true);
            panal.SetActive(true);

            player.enegry += addEnegry;
            player.happy += addHappy;
            player.money += addMoney;
            player.timeHour += addTimeHour;
            player.timeMinute += addTimeMinute;
            player.SavePlayer();
            SceneManager.LoadScene("Gameplay");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        check = 0;
    }
    public void EjectBotton()
    {
        addEnegry = Random.Range(-11, 11);
        addHappy = Random.Range(-11, 11);
        addMoney = Random.Range(0, 15);

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
}
