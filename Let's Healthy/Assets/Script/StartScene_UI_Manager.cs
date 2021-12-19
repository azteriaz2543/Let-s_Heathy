using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene_UI_Manager : MonoBehaviour
{

    Player player;

    public GameObject Register_Panel ,Help_Panel ,ChoseNone ,ChoseNephropathy ,ConfirmButton;
    public InputField PlayerName;
    public Image charImage;
    public Sprite [] charImageSouce;

    int NowChar;
    bool ShowHelp;
    int NowMode;

    int random;
    string randomName;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        Register_Panel.SetActive(player.firstStart);

        NowChar = 0;

        ChoseNone.SetActive(false);
        ChoseNephropathy.SetActive(false);

        ShowHelp = false;

        ConfirmButton.SetActive(false);

        random = Random.Range(1,6);

        switch (random)
        {
            case 1:
                randomName = "แสงสว่าง แพรวพราวว";
                break;
            case 2:
                randomName = "John";
                break;
            case 3:
                randomName = "Jessica";
                break;
            case 4:
                randomName = "Umezeiros Oakmight";
                break;
            case 5:
                randomName = "Eovira Mildflower";
                break;
        }

    }

    void Update()
    {
        charImage.GetComponent<Image>().sprite = charImageSouce[NowChar];
        Help_Panel.SetActive(ShowHelp);
    }

    #region Button
    public void LeftChar()
    {
        NowChar--;

        if (NowChar == -1)
        {
            NowChar = charImageSouce.Length - 1;
        }
    }

    public void RigthChar()
    {
        NowChar++;

        if (NowChar == charImageSouce.Length)
        {
            NowChar = 0;
        }
    }

    public void None()
    {
        ChoseNone.SetActive(true);
        ChoseNephropathy.SetActive(false);
        NowMode = 0;
        ConfirmButton.SetActive(true);
    }

    public void Nephropathy()
    {
        ChoseNone.SetActive(false);
        ChoseNephropathy.SetActive(true);
        NowMode = 1;
        ConfirmButton.SetActive(true);
    }

    public void Help()
    {
        ShowHelp = !ShowHelp;
    }

    public void Confirm()
    {
        if (PlayerName.text == "")
        {
            player.playerName = randomName;
        }
        else
        {
            player.playerName = PlayerName.text;
        }
        
        player.mode = NowMode;
        player.character = NowChar;
        player.GotoMenu();
    }
    #endregion

}
