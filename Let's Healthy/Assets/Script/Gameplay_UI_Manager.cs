﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    }

    // Update is called once per frame
    void Update()
    {
        
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
        FitnessEvent.SetActive(true);
        Step = "Fitness";
        DayPanel.SetActive(false);
    }

    public void Back_Fitness()
    {
        FitnessEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    public void Office()
    {
        OfficeEvent.SetActive(true);
        Step = "Office";
        DayPanel.SetActive(false);
    }

    public void Back_Office()
    {
        OfficeEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    public void Hospital()
    {
        HospitalEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
    }

    public void Back_Hospital()
    {
        HospitalEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    public void School()
    {
        SchoolEvent.SetActive(true);
        Step = "Hospital";
        DayPanel.SetActive(false);
    }

    public void Back_School()
    {
        SchoolEvent.SetActive(false);
        Step = "Map";
        DayPanel.SetActive(true);
    }
    #endregion
}
