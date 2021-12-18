using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class PanelSettings : MonoBehaviour {
    DragDropManager DDM;

    // the Id of this panel
    public string Id;

    // Enums
    public enum ObjectPosStates { UseObjectSettings, DroppedPosition, PanelPosition };
    public enum ObjectLockStates { UseObjectSettings, LockObject, DoNotLockObject };
    public enum ObjectReplace { Allowed, NotAllowed, MultiObjectMode };
    //

    // Customization Tools
    [Header("Object Position")]
    [Tooltip("Customize the position of object when dropped on this panel")]
    public ObjectPosStates ObjectPosition;

    [Header("Lock Object")]
    [Tooltip("Customize Object Locking")]
    public ObjectLockStates LockObject;

    [Header("Replacement & Multi Object")]
    [Tooltip("Allow Object to Replace & Switch or use Multi Object Mode")]
    public ObjectReplace ObjectReplacement;
    //

    [Header("Events Management")]
    [Tooltip("When any object dropped on the panel, the functions that you added to this event trigger will be called")]
    public UnityEvent OnObjectDropped;

    [HideInInspector]
    // using for Multi Object tool
    public List<string> PanelIdManager;

    Kitchen_UI kitchen_UI;
    public string currentItem;
    Cooking cooking;

    GameObject BlockInv;
    Transform near;
    Transform far;

    CutBoard cutBoard;


    void Start() {
        // Getting current DDM GameObject
        DDM = GameObject.Find("DDM").GetComponent<DragDropManager>();

        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();
        BlockInv = GameObject.Find("BlockInv");

        near = GameObject.Find("NearInv").transform;
        far = GameObject.Find("FarInv").transform;

        cutBoard = GameObject.Find("CutBoardSc").GetComponent<CutBoard>();
    }
    void Update()
    {


    }

    public void SetupPanelEvents() {
        // Events Management
        if (OnObjectDropped != null) {
            OnObjectDropped.Invoke();
        }
    }

    public void SetMultiObject(string ObjectId) {
        // Adding new object to the list of dropped objects
        PanelIdManager.Add(ObjectId);

        if (DDM.SaveStates) {
            SaveObjectsList();
        }
    }

    public void AddItem()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);

        if (currentItem != ObjectId)
        {
            if (currentItem != "" || currentItem != "Reset")
            {
                kitchen_UI.RemoveInventory(currentItem);
            }
            currentItem = ObjectId;
            kitchen_UI.AddInventory(currentItem);

        }

    }

    public void ResetCI()
    {
        currentItem = "Reset";
    }

    public void Return()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        DragDropManager.ResetOnlyObject(ObjectId);
        kitchen_UI.RemoveInventory(ObjectId);
        GameObject ReturnItem = GameObject.Find(ObjectId);

        if (kitchen_UI.OpenFridge == false)
        {

            if (ObjectId == "Spoon" || ObjectId == "Turner" || ObjectId == "Rice" || ObjectId == "Water" || ObjectId == "RiceC")
            {
                ReturnItem.SetActive(true);
            }
            else
            {
                ReturnItem.SetActive(false);
            }
        }

    }

    public void RemoveMultiObject(string ObjectId) {
        // Removing an object from list of dropped objects
        if (DDM.SaveStates) {
            PlayerPrefs.DeleteKey(Id + "&&" + (PanelIdManager.Count - 1).ToString());
        }

        PanelIdManager.Remove(ObjectId);
    }

    void SaveObjectsList() {
        for (int i = 0; i < PanelIdManager.Count; i++) {
            PlayerPrefs.SetString(Id + "&&" + i.ToString(), PanelIdManager[i]);
        }
    }

    public void LoadObjectsList() {
        // loading list of dropped objects
        for (int i = 0; i < DragDropManager.DDM.AllObjects.Length; i++) {
            if (PlayerPrefs.HasKey(Id + "&&" + i.ToString())) {
                PanelIdManager.Add(PlayerPrefs.GetString(Id + "&&" + i.ToString()));
            }
        }

        for (int i = 0; i < PanelIdManager.Count; i++) {
            for (int j = 0; j < DragDropManager.DDM.AllObjects.Length; j++) {

                if (DragDropManager.DDM.AllObjects[j].Id == PanelIdManager[i]) {
                    DragDropManager.DDM.AllObjects[j].GetComponent<RectTransform>().SetAsLastSibling();

                    for (int k = 0; k < DragDropManager.DDM.AllPanels.Length; k++) {
                        if (DragDropManager.DDM.AllPanels[k].Id == Id) {
                            DragDropManager.DDM.SetPanelObject(k, DragDropManager.DDM.AllObjects[j].Id);
                        }
                    }
                }
            }
        }
    }

    string ItemInCut;

    public void CheckForCut()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);

        if (currentItem != ObjectId)
        {
            currentItem = ObjectId;
        }

        BlockInv.transform.position = near.transform.position;
        

        if (currentItem == "Knife1")
        {

            for (int i = 0; i < PanelIdManager.Count; i++)
            {
                if (PanelIdManager[i] != "Knife1")
                {
                    DragDropManager.ResetOnlyObject(PanelIdManager[i]);
                    cooking.SpawnCutedItem(PanelIdManager[i]);
                    kitchen_UI.RemoveInventory(PanelIdManager[i]);
                    break;
                }
            }

            BlockInv.transform.position = far.transform.position;
            PanelIdManager.Clear();
            DragDropManager.ResetOnlyObject("Knife1");
            cutBoard.HideCut();
        }
        else
        {
            ItemInCut = currentItem;
            kitchen_UI.RemoveInventoryOnly(currentItem);
        }

    }

    public void ItemInCutGoBack()
    {
        DragDropManager.ResetOnlyObject(ItemInCut);
        ItemInCut = "";
    }

    public void SpawnItem()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();

        if (ObjectId == "Spoon" || ObjectId == "Turner" || ObjectId == "Water" || ObjectId == "RiceC")
        {
            cooking.Spawn(ObjectId);
        }

        if (kitchen_UI.CheckInventory(ObjectId) == true)
        {
            cooking.Spawn(ObjectId);
            kitchen_UI.RemoveInventory(ObjectId);

        }

        Return();
    }

    public void CounterSpawn()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();

        cooking.DisplayFood(ObjectId);

        if (kitchen_UI.CheckInventory(ObjectId) == true)
        {
            kitchen_UI.RemoveInventoryOnly(ObjectId);
        }

        Return();


    }

    public void IconControl (KnifeIcon knifeIcon)
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        knifeIcon = knifeIcon.GetComponent<KnifeIcon>();
        knifeIcon.CanCutItem(currentItem);
    }

    public void Beating()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        switch (ObjectId)
        {
            case "Egg1":
            case "Egg2":
            case "Egg3":
            case "Egg4":
                kitchen_UI.Beating(ObjectId);
                break;
        }
        
        Return();
    }

    public void Bowling()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        switch (ObjectId)
        {
            case "Egg1":
            case "Egg2":
            case "Egg3":
            case "Egg4":
                kitchen_UI.Bowling(ObjectId);
                break;
        }

        Return();
    }


}