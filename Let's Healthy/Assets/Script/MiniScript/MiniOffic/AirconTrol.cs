using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AirconTrol : MonoBehaviour
{
    int airNumber, aircouter, coutdown;
    public Text airNumtext, aircoutext;

    // Start is called before the first frame update
    void Start()
    {
        startgame();

    }

    // Update is called once per frame
    void Update()
    {
        airNumtext.text = airNumber.ToString();
        aircoutext.text = aircouter.ToString();
        if (coutdown == 3)
        {
            SceneManager.LoadScene("Gameplay");
        }
        if (aircouter == airNumber)
        {
            coutdown += 1;
            startgame();
        }
    }

    public void Addaircout()
    {
        aircouter += 1;
    }
    public void Negetaircout()
    {
        aircouter -= 1;
    }

    void startgame()
    {
        airNumber = Random.Range(16, 33);
        print(airNumber);
        aircouter = Random.Range(1, 40);
        if (aircouter == airNumber)
        {
            int airRand = Random.Range(1, 3);
            switch (airRand)
            {
                case 1:
                    aircouter += Random.Range(1, 11);
                    break;
                case 2:
                    aircouter -= Random.Range(1, 11);
                    break;
            }
        }
    }
}

