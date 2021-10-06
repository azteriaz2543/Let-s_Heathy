using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject ChooseWay, MenuWay ,MenuList ,HideMenu;
    public Text Title, Title_TH, HowTo;
    public GameObject[] MaterialList;
    public GameObject BlockImage;

    bool showMenu = false;

    public DoingZoneControl doingZoneControl;

    public GameObject[] BeatItems;

    public GameObject BlockInv;
    public Transform far;

    public GameObject ConclusionButton;
    public GameObject ConclusionPanel;

    public FinishCook finishCook;
    public Text CText2, CText3, CText4, CText5, CText6, CText7;

    public GameObject[] Condiment;
    public GameObject ShelfBG;
    bool OpenShelf;

    public GameObject HouseBackButton;

    void Start()
    {
        Inventory = new List<GameObject>();

        ShowInv = true;

        SetAllFalse();

        RemoveZone.SetActive(false);

        dropHere = GameObject.FindGameObjectWithTag("Drop").GetComponent<DropHere>();

        cooking = cooking.GetComponent<Cooking>();

        MenuList.SetActive(false);

        MenuWay.SetActive(false);

        doingZoneControl = doingZoneControl.GetComponent<DoingZoneControl>();

        finishCook = finishCook.GetComponent<FinishCook>();
    }


    void Update()
    {
        InventoryZone.SetActive(ShowInv);

        MenuList.SetActive(showMenu);

        CText2.text = "����ҳ����� : " + finishCook.Sodium.ToString();
        CText3.text = "����ҳ��ѹ : " + finishCook.Fat.ToString();
        CText4.text = "����ҳ�õչ : " + finishCook.Protein.ToString();
        CText5.text = "����ҳ�������� : " + finishCook.KiloCalories.ToString();
        CText6.text = "��Ҥ����آ : " + finishCook.Happiness.ToString();
        CText7.text = "��ѧ�ҹ : XXX";
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
                    HideItem();
                }
            }
        }

    }

    public void RemoveInventoryOnly(string itemName)
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
        HideItem();
        GameObject.Find("IconControl1").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl2").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl3").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl4").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl5").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl6").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl7").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl8").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl9").GetComponent<KnifeIcon>().Show = false;
        GameObject.Find("IconControl10").GetComponent<KnifeIcon>().Show = false;
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
        HouseBackButton.SetActive(false);
    }

    public void CuttingBoard()
    {
        CuttingBoardPanel.SetActive(true);
        CloseButton.SetActive(true);
        CutBoardZone.SetActive(true);
        Map.SetActive(false);
        Knife.SetActive(true);
        Cuting = true;
        HouseBackButton.SetActive(false);
    }

    public void Incubator()
    {
        IncubatorPanel.SetActive(true);
        CloseButton.SetActive(true);
        HouseBackButton.SetActive(false);
    }

    public void Main()
    {
        MainPanel.SetActive(true);
        CloseButton.SetActive(true);
        CounterZone.SetActive(true);
        Map.SetActive(false);
        HouseEvent.SetActive(false);
        CounterBG.SetActive(true);
        HouseBackButton.SetActive(false);
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
        HouseBackButton.SetActive(false);
    }

    public void Shelf()
    {
        for (int i = 0; i < Condiment.Length; i++)
        {
            Condiment[i].SetActive(true);
        }

        HouseEvent.SetActive(false);
        Map.SetActive(false);
        CloseButton.SetActive(true);
        ShelfPanel.SetActive(true);
        CloseButton.SetActive(true);
        ShelfBG.SetActive(true);
        OpenShelf = true;
        HouseBackButton.SetActive(false);
    }

    public void Microwave()
    {
        MicrowavePanel.SetActive(true);
        CloseButton.SetActive(true);
        HouseBackButton.SetActive(false);
    }

    public void SetAllFalse()
    {
        HouseBackButton.SetActive(true);
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

        doingZoneControl.ThrownAway();

        BlockInv.transform.position = far.transform.position;

        ConclusionButton.SetActive(false);
        ConclusionPanel.SetActive(false);

        ShelfBG.SetActive(false);
        OpenShelf = false;
    }

    public void HideItem()
    {
        if (OpenFridge == false)
        {
            for (int i = 0; i < FridgeItem.Length; i++)
            {
                FridgeItem[i].SetActive(false);
            }
        }

        for (int i = 0; i < cooking.CutedItems.Length; i++)
        {
            cooking.CutedItems[i].SetActive(false);
        }

        for (int i = 0; i < cooking.Food.Length; i++)
        {
            cooking.Food[i].SetActive(false);
        }

        for (int i = 0; i < cooking.FinishCook.Length; i++)
        {
            cooking.FinishCook[i].SetActive(false);
        }

        for (int i = 0; i < BeatItems.Length; i++)
        {
            BeatItems[i].SetActive(false);
        }

        for (int i = 0; i < Condiment.Length; i++)
        {
            Condiment[i].SetActive(false);
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

    public void Custom()
    {
        ChooseWay.SetActive(false);
        HideMenu.SetActive(false);
        BlockImage.SetActive(false);
    }

    public void Menu()
    {
        ChooseWay.SetActive(false);
        MenuWay.SetActive(true);
        HideMenu.SetActive(true);
        BlockImage.SetActive(false);
    }

    public void HideMenuButton()
    {
        showMenu = !showMenu;
    }

    public void Conclusion()
    {
        ConclusionPanel.SetActive(true);
    }

    public void Next()
    {
        //Active Food Status
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

    #region Menu

    public void ChooseMenu()
    {
        MenuList.SetActive(true);
        BlockImage.SetActive(false);
        MenuWay.SetActive(false);
        showMenu = true;
    }

    public void Omelet()
    {
        Title.text = "Omelet";
        Title_TH.text = "������";
        HowTo.text ="1 ��Ժ�� ����ѵ����蹷�������\n"+"2 价������ �������͡�з�\n" +"3 ����ѵ�شԺ�����ŧ�\n"
                    +"4 ��������������㹡�÷�����ô���\n"+"5 �Դ� �Шѧ��������ش������ �����\n"+"6 ������ҹ������Ѻ�������";
        MaterialList[0].SetActive(true);
        
    }

    #endregion

    public void ResetKitchen()
    {
        showMenu = false;
        ChooseWay.SetActive(true);
        HideMenu.SetActive(false);
        Inventory = new List<GameObject>();
        HideItem();
        BlockImage.SetActive(true);
        ConclusionButton.SetActive(false);
        finishCook.Reset();
    }

    string targetBeat;

    public void Beating(string ObjectId)
    {
        switch (ObjectId)
        {
            case "Egg1":
                targetBeat = "EggBeat1";
                break;
            case "Egg2":
                targetBeat = "EggBeat2";
                break;
            case "Egg3":
                targetBeat = "EggBeat3";
                break;
            case "Egg4":
                targetBeat = "EggBeat4";
                break;
        }

        for (int i = 0; i < BeatItems.Length; i++)
        {
            if (BeatItems[i].name == targetBeat)
            {
                RemoveInventory(ObjectId);
                BeatItems[i].SetActive(true);
                targetBeat = "";
            }
            
        }

        

    }

}
