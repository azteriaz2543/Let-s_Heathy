using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniHPT3 : MonoBehaviour
{
    [SerializeField] Text miniGameHPT3text,bB;
    int c_random;
    [SerializeField]InputField inputField;
    string a;
    public GameObject panal;
    Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    int addTimeMinute, addTimeHour;
    float addEnegry, addHappy;
    int addMoney;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        c_random = Random.Range(32, 40);
        panal.SetActive(false);
        EjectBotton();
    }

    // Update is called once per frame
    void Update()
    {
        a=inputField.text;
        print(a);
        if (int.Parse(a) ==c_random)
        {
            bB.text = "Succeed";
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        miniGameHPT3text.text = c_random.ToString();
        print("c_random");
    }
    public void EjectBotton()
    {
        addEnegry = Random.Range(-11, 11);
        addHappy = Random.Range(-11, 11);
        addMoney = Random.Range(0,15);

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
