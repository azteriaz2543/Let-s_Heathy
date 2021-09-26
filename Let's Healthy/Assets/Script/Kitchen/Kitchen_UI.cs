using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_UI : MonoBehaviour
{

    public GameObject CuttingBoardPanel, IncubatorPanel, MainPanel, StovePanel, ShelfPanel ,CloseButton,HouseEvent,Map,MicrowavePanel;

    public GameObject[] FridgeItem;
    public List<GameObject> Inventory;

    public GameObject InventoryZone;
    bool ShowInv;
    public GameObject RemoveZone;

    public GameObject CutBoardZone;
    public GameObject Knife;

    public bool OpenFridge;

    bool have;

    public GameObject StoveBG;
    public GameObject StoveDD;

    public bool Cuting;

    public DropHere dropHere;

    public GameObject CounterZone;
    public GameObject CounterBG;

    public Cooking cooking;

    void Start()
    {
        Inventory = new List<GameObject>();

        ShowInv = true;

        SetAllFalse();

        RemoveZone.SetActive(false);

        dropHere = GameObject.FindGameObjectWithTag("Drop").GetComponent<DropHere>();

        cooking = cooking.GetComponent<Cooking>();

    }

    
    void Update()
    {
        InventoryZone.SetActive(ShowInv);
    }

    public void AddInventory(string itemName)
    {
        GameObject Item = GameObject.Find(itemName);

        if (Inventory.Count > 0)
        {
            
            foreach (GameObject item in Inventory)
            {
                if (item != Item)
                {
                    have = false;
                    continue;
                }
                else
                {
                    have = true;
                    break;
                }
            }

            if (have == false)
            {
                Inventory.Add(Item);
            }            

        }
        else
        {
            Inventory.Add(Item);
        }
         

    }

    public void RemoveInventory(string itemName)
    {
        GameObject Item = GameObject.Find(itemName);

        if (Inventory.Count > 0)
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i] == Item)
                {
                    Inventory.RemoveAt(i);
                }
            }
        }
        
    }
    public void Reset()
    {
        Inventory = new List<GameObject>();
    }

    public void OnItemDrag()
    {
        RemoveZone.SetActive(true);
    }

    public void OnItemDrop()
    {
        RemoveZone.SetActive(false);
    }

    #region Button
    public void Fridge()
    {
        for (int i = 0; i < FridgeItem.Length; i++)
        {
            FridgeItem[i].SetActive(true);
        }

        HouseEvent.SetActive(false);
        Map.SetActive(false);
        CloseButton.SetActive(true);
        ShowInv = true;
        OpenFridge = true;
    }

    public void CuttingBoard()
    {
        CuttingBoardPanel.SetActive(true);
        CloseButton.SetActive(true);
        CutBoardZone.SetActive(true);
        Map.SetActive(false);
        Knife.SetActive(true);
        Cuting = true;
    }

    public void Incubator()
    {
        IncubatorPanel.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void Main()
    {
        MainPanel.SetActive(true);
        CloseButton.SetActive(true);
        CounterZone.SetActive(true);
        Map.SetActive(false);
        HouseEvent.SetActive(false);
        CounterBG.SetActive(true);
        dropHere.Counter();
    }

    public void Stove()
    {
        StovePanel.SetActive(true);
        CloseButton.SetActive(true);
        StoveBG.SetActive(true);
        StoveDD.SetActive(true);
        Map.SetActive(false);
        HouseEvent.SetActive(false);
        dropHere.Stove();
    }

    public void Shelf()
    {
        ShelfPanel.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void Microwave()
    {
        MicrowavePanel.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void SetAllFalse()
    {
        
        CuttingBoardPanel.SetActive(false);
        IncubatorPanel.SetActive(false);
        MainPanel.SetActive(false);
        StovePanel.SetActive(false);
        ShelfPanel.SetActive(false);
        CloseButton.SetActive(false);
        HouseEvent.SetActive(true);
        Map.SetActive(true);
        CutBoardZone.SetActive(false);
        MicrowavePanel.SetActive(false);
        OpenFridge = false;
        StoveBG.SetActive(false);
        StoveDD.SetActive(false);
        Cuting = false;

        CounterZone.SetActive(false);
        CounterBG.SetActive(false);

        HideItem();

        Knife.SetActive(false);

        dropHere.NoDrop();

    }

    public void HideItem()
    {
        for (int i = 0; i < FridgeItem.Length; i++)
        {
            FridgeItem[i].SetActive(false);
        }

        for (int i = 0; i < cooking.CutedCarrot.Length; i++)
        {
            cooking.CutedCarrot[i].SetActive(false);
        }

        for (int i = 0; i < cooking.Food.Length; i++)
        {
            cooking.Food[i].SetActive(false);
        }

        for (int i = 0; i < cooking.FinishCook.Length; i++)
        {
            cooking.FinishCook[i].SetActive(false);
        }

        for (int i = 0; i < Inventory.Count; i++)
        {
            Inventory[i].SetActive(true);
        }
    }

    public void InventoryButton()
    {
        ShowInv = !ShowInv;

        for (int i = 0; i < Inventory.Count; i++)
        {
            Inventory[i].SetActive(ShowInv);
        }

    }

    #endregion

    public bool CheckInventory(string ItemName)
    {
        bool find = false;

            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i].gameObject.name == ItemName)
                {
                    find = true;
                    break;
                }
                else
                {
                    find = false;
                }
            }

        return find;

    }



}
