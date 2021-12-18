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
    public Text Title, Title_TH;
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
    public Text CText1, CText2, CText3, CText4, CText5, CText6, CText7;

    public GameObject[] Condiment;
    public GameObject ShelfBG;
    bool OpenShelf;

    public GameObject HouseBackButton;
    int menuNo;

    Player player;

    public GameObject[] BowlItems;

    float healthyTemp;

    void Start()
    {
        finishCook = finishCook.GetComponent<FinishCook>();
        dropHere = GameObject.FindGameObjectWithTag("Drop").GetComponent<DropHere>();
        doingZoneControl = doingZoneControl.GetComponent<DoingZoneControl>();
        cooking = cooking.GetComponent<Cooking>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        Inventory = new List<GameObject>();

        ShowInv = true;

        RemoveZone.SetActive(false);

        MenuList.SetActive(false);

        MenuWay.SetActive(false);

        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }

        SetAllFalse();

    }


    void Update()
    {
        InventoryZone.SetActive(ShowInv);

        MenuList.SetActive(showMenu);

        CText1.text = "ปริมาณโซเดียม : " + finishCook.Sodium.ToString() + " กรัม";
        CText2.text = "ปริมาณไขมัน : " + finishCook.Fat.ToString() + " กรัม";
        CText3.text = "ปริมาณโปรตีน : " + finishCook.Protein.ToString() + " กรัม";
        CText4.text = "ปริมาณคอลลอรี่ : " + finishCook.KiloCalories.ToString() + " กิโลแคลอรี่";
        CText5.text = "ค่าความสุข : " + finishCook.Happiness.ToString() + " หน่วย";

        if (player.mode == 0)
        {
            CText6.text = "ค่าสุขภาพ : " + finishCook.Healthy.ToString() + " หน่วย";
            healthyTemp = finishCook.Healthy;
        }
        else if(player.mode == 1)
        {
            CText6.text = "ค่าสุขภาพ : " + finishCook.NephropathyHealthy.ToString() + " หน่วย";
            healthyTemp = finishCook.NephropathyHealthy;
        }

        if (healthyTemp <= 0)
        {
            healthyTemp = 0;
        }

        if (healthyTemp == 0)
        {
            CText7.text = "อาหารมื้อนี้ดีต่อสุขภาพจริงๆ ทำให้ดีแบบนี้ต่อไปนะ ^^";
        }
        else if (healthyTemp > 0 && healthyTemp <= 25)
        {
            CText7.text = "กำลังดูดีเลย ลองลดส่วนผสมอีกนิดหน่อยนะ";
        }
        else if (healthyTemp > 25 && healthyTemp <= 50)
        {
            CText7.text = "ปริมาณโซเดี่ยมเริ่มจะไม่ดีแล้ว ลองลดลงให้มากกว่านี้หน่อยนะ";
        }
        else if (healthyTemp > 50 && healthyTemp <= 60)
        {
            CText7.text = "ปริมาณโซเดี่ยมมากเกินไปแล้ว ไม่ควรกินอาหารแบบนี้เท่าไหร่นะ";
        }
        else if (healthyTemp > 60 && healthyTemp <= 75)
        {
            CText7.text = "ถ้าหากทานอาหารแบบนี้ต่อไปจะไม่ดีต่อสุขภาพนะ";
        }
        else if (healthyTemp > 75)
        {
            CText7.text = "อาหารจานนี้แย่มาก ควรไปปรึกษาแพทย์";
        }

        if (Input.GetMouseButtonUp(0))
        {
            RemoveZone.SetActive(false);
        }

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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Item);
    }

    public void OnItemDrop()
    {
        RemoveZone.SetActive(false);
        Sound_Manager.PlaySound(Sound_Manager.Sound.Item);
    }

    #region Button
    public void Fridge()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        IncubatorPanel.SetActive(true);
        CloseButton.SetActive(true);
        HouseBackButton.SetActive(false);
    }

    public void Main()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        MicrowavePanel.SetActive(true);
        CloseButton.SetActive(true);
        HouseBackButton.SetActive(false);
    }

    public void SetAllFalse()
    {
        cooking.Pan.SetActive(false);
        cooking.Pot.SetActive(false);
        cooking.Bowl.SetActive(false);
        cooking.Gas.SetActive(true);

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
        OpenShelf = false;

        CounterZone.SetActive(false);
        CounterBG.SetActive(false);

        

        Knife.SetActive(false);

        dropHere.NoDrop();

        doingZoneControl.ThrownAway();

        BlockInv.transform.position = far.transform.position;

        ConclusionButton.SetActive(false);
        ConclusionPanel.SetActive(false);

        ShelfBG.SetActive(false);

        HideItem();

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

        if (OpenShelf == false)
        {
            for (int i = 0; i < Condiment.Length; i++)
            {
                Condiment[i].SetActive(false);
            }
        }

        for (int i = 0; i < BowlItems.Length; i++)
        {
            BowlItems[i].SetActive(false);
        }

        for (int i = 0; i < Inventory.Count; i++)
        {
            Inventory[i].SetActive(true);
        }

    }

    public void InventoryButton()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        ShowInv = !ShowInv;

        for (int i = 0; i < Inventory.Count; i++)
        {
            Inventory[i].SetActive(ShowInv);
        }

    }

    public void Custom()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        ChooseWay.SetActive(false);
        HideMenu.SetActive(false);
        BlockImage.SetActive(false);
    }

    public void Menu()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        ChooseWay.SetActive(false);
        MenuWay.SetActive(true);
        HideMenu.SetActive(true);
        BlockImage.SetActive(false);
    }

    public void HideMenuButton()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        showMenu = !showMenu;
        MaterialList[menuNo].SetActive(true);
    }

    public void Conclusion()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.MissionClear);
        ConclusionPanel.SetActive(true);
    }

    public void Next()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        player.sodium += finishCook.Sodium;
        player.fat += finishCook.Fat;
        player.protein += finishCook.Protein;
        player.kiloCaloriesl += finishCook.KiloCalories;
        player.happy += finishCook.Happiness;

        if (player.timeHour > 5 && player.timeHour <= 8)
        {
            player.clear1 = true;
            player.timeHour += 1;
        }
        else if (player.timeHour > 11 && player.timeHour <= 14)
        {
            player.clear2 = true;
            player.timeHour += 1;
        }
        else if (player.timeHour > 17 && player.timeHour <= 20)
        {
            player.clear3 = true;
            player.timeHour += 1;
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
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Omelet";
        Title_TH.text = "ไข่เจียว";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[0].SetActive(true);
        menuNo = 0;
    }
    public void BoiledRice()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "BoiledRice";
        Title_TH.text = "ข้าวต้ม";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[1].SetActive(true);
        menuNo = 1;
    }
    public void ChickenbreastLemonSause()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Chickenbreast";
        Title_TH.text = "อกไก่ซอสมะนาว"; 
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[2].SetActive(true);
        menuNo = 2;
    }
    public void FriedbasilMincedpork()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "FriedbasilMincedPork";
        Title_TH.text = "ผัดกระเพราหมูสับ";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[3].SetActive(true);
        menuNo = 3;
    }
    public void FriedriceGinger()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Friedrice Ginger";
        Title_TH.text = "ข้าวผัดขิง";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[4].SetActive(true);
        menuNo = 4;
    }
    public void FriedricePork()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Friedrice Pork";
        Title_TH.text = "ข้าวผัดหมู";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[5].SetActive(true);
        menuNo = 5;
    }
    public void HainaneseChickenRice()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "HainaneseChicken";
        Title_TH.text = "ข้าวมันไก่";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[6].SetActive(true);
        menuNo = 6;
    }
    public void Massaman()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Massaman";
        Title_TH.text = "มัสมั่น";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[7].SetActive(true);
        menuNo = 7;
    }
    public void PoachedEggs()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "PoachedEggs";
        Title_TH.text = "ไข่ดาวน้ำ";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[8].SetActive(true);
        menuNo = 8;
    }
    public void RainbowSoup()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "RainbowSoup";
        Title_TH.text = "ซุปมหัศจรรย์";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[9].SetActive(true);
        menuNo = 9;
    }

    public void Sandwich()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
        Title.text = "Sandwich";
        Title_TH.text = "แซนวิช";
        for (int i = 0; i < MaterialList.Length; i++)
        {
            MaterialList[i].SetActive(false);
        }
        MaterialList[10].SetActive(true);
        menuNo = 10;
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
                doingZoneControl.isBeat = false;
                Sound_Manager.PlaySound(Sound_Manager.Sound.BeatEgg);
                RemoveInventory(ObjectId);
                BeatItems[i].SetActive(true);
                targetBeat = "";
            }
        }
    }

    string targetBowl;

    public void Bowling(string ObjectId)
    {
        switch (ObjectId)
        {
            case "Egg1":
                targetBowl = "WhiteEgg1";
                break;
            case "Egg2":
                targetBowl = "WhiteEgg2";
                break;
            case "Egg3":
                targetBowl = "WhiteEgg3";
                break;
            case "Egg4":
                targetBowl = "WhiteEgg4";
                break;
        }

        for (int i = 0; i < BowlItems.Length; i++)
        {
            if (BowlItems[i].name == targetBowl)
            {
                doingZoneControl.isBowl = false;
                Sound_Manager.PlaySound(Sound_Manager.Sound.Button);
                RemoveInventory(ObjectId);
                BowlItems[i].SetActive(true);
                targetBowl = "";
            }
        }
    }

}
