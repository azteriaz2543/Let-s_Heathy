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

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        Register_Panel.SetActive(player.firstStart);

        NowChar = 0;

        ChoseNone.SetActive(false);
        ChoseNephropathy.SetActive(false);

        ShowHelp = false;

        ConfirmButton.SetActive(false);
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
        player.playerName = PlayerName.text;
        player.mode = NowMode;
        player.character = NowChar;
        player.GotoMenu();
    }
    #endregion

}
