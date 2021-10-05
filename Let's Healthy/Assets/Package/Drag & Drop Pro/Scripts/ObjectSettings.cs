using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ObjectSettings : MonoBehaviour
{

    // DDM Game Object
    DragDropManager DDM;

    // Rect Transform Component of this object
    RectTransform thisRT;

    // Parent of this object
    Transform thisParent;

    // Vector3 variables
    Vector3 CurrentPos;
    Vector3 MousePos;
    [HideInInspector]
    public Vector3 FirstPos;
    [HideInInspector]
    public Vector3 FirstScale;
    //

    // Bools
    bool PDown = false;
    bool CheckStatus = false;
    [HideInInspector]
    public bool DefaultPanel = false;
    [HideInInspector]
    public bool Dropped = false;
    [HideInInspector]
    public bool OnReturning = false;
    //

    //using for dragging mode
    float differenceX;
    float differenceY;
    //

    // Customization Tools
    public string Id;   // the Id of this object

    [Tooltip("Allow user to control this object")]
    public bool UserControl = true;

    [Tooltip("Allow AI to control this object")]
    public bool AIControl = true;

    [Header("Return Object Smoothly (DragDrop Failed)")]
    [Tooltip("Return Object to its first Position Smoothly When DragDrop Failed")]
    public bool ReturnSmoothly = false;
    [Tooltip("Returning speed")]
    [Range(0.1f, 2.0f)]
    public float ReturnSpeed = 1.0f;

    [Header("Scale Object (Dragging)")]
    [Tooltip("Scale Object When dragging was begun")]
    public bool ScaleOnDrag = false;
    [Tooltip("Object Scale")]
    public Vector3 DragScale = new Vector3(1.0f, 1.0f, 1.0f);

    [Header("Stay Object on dropped position")]
    [Tooltip("Stay Object on dropped position When the Object dropped successfully")]
    public bool StayDroppedPos = false;

    [Header("Scale Object (Dropped successfully)")]
    [Tooltip("Scale Object When dropped successfully")]
    public bool ScaleOnDropped = false;
    [Tooltip("Object Scale")]
    public Vector3 DropScale = new Vector3(1.0f, 1.0f, 1.0f);

    [Header("Locking Object")]
    [Tooltip("Lock Object When dropped successfully")]
    public bool LockObject = false;

    [Header("Return Object (Dropped successfully)")]
    [Tooltip("Return Object to its first position When dropped successfully")]
    public bool ReturnObject = false;

    [Header("Smooth Replacement")]
    [Tooltip("Replace Object smoothly When dropped successfully")]
    public bool ReplaceSmoothly = false;
    [Range(0.1f, 2.0f)]
    public float ReplacementSpeed = 1.0f;

    [Header("Allow to switch Objects")]
    [Tooltip("Allow to switch Objects between panels")]
    public bool SwitchObjects = false;
    [Tooltip("Move Object smoothly When it was switching")]
    public bool MoveSmoothly = false;
    [Range(0.1f, 2.0f)]
    public float MovementSpeed = 1.0f;

    [Header("Filter Panels")]
    [Tooltip("Allow using Filter Panels tool")]
    public bool FilterPanels = false;
    [Tooltip("The Ids of the panels that object allowed to drop on them")]
    public string[] AllowedPanels;

    [Header("Events Management")]
    public UnityEvent OnBeginDragging;
    public UnityEvent OnDragDropFailed;
    public UnityEvent OnDroppedSuccessfully;
    //
    CutBoard CutBoardZone;
    Kitchen_UI kitchen_UI;

    void Start()
    {
        GetGameObjects();

        OnDragDropFailed.AddListener(IconOnDrop);
        OnDroppedSuccessfully.AddListener(IconOnDrop);
    }

    void GetGameObjects()
    {
        // Getting Rect Transform component of this object
        thisRT = GetComponent<RectTransform>();

        // Getting the parent of this object
        thisParent = thisRT.parent;

        // Getting DDM GameObject
        DDM = GameObject.Find("DDM").GetComponent<DragDropManager>();
        CutBoardZone = GameObject.FindGameObjectWithTag("Cut").GetComponent<CutBoard>();
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
    }

    void Update()
    {
        DragObject();
    }

    void DragObject()
    {
        if (PDown)
        {
            SetMousePos();

            if (DDM.DraggingModes == DragDropManager.DragModes.ChangeToMousePos)
            {
                thisRT.position = new Vector3(MousePos.x, MousePos.y, thisRT.position.z);
            }
            else
            {
                thisRT.position = new Vector3(MousePos.x + differenceX, MousePos.y + differenceY, thisRT.position.z);
            }
        }
    }

    public void PointerDown(string state, string AIPanel)
    {
        if (state == "User" && UserControl)
        {
            PointerDownActions(state, AIPanel);
        }
        else if (state == "AI" && AIControl)
        {
            PointerDownActions(state, AIPanel);
        }
    }

    void PointerDownActions(string state, string AIPanel)
    {
        if (Dropped)
        {
            // Setup customization tools of the panel
            int index = DDM.IdManager.IndexOf(Id);
            try
            {
                if (DDM.AllPanels[index].LockObject != PanelSettings.ObjectLockStates.LockObject)
                {
                    if (!LockObject || DDM.AllPanels[index].LockObject == PanelSettings.ObjectLockStates.DoNotLockObject)
                    {
                        BeginDragging(state, AIPanel);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        else
        {
            BeginDragging(state, AIPanel);
        }
    }

    void BeginDragging(string state, string AIPanel)
    {
        CurrentPos = thisRT.position;

        if (ScaleOnDrag)
        { // Setup ScaleOnDrag tool
            thisRT.localScale = DragScale;
        }

        thisRT.SetParent(DDM.SecondCanvas.GetComponent<RectTransform>());

        if (state == "User")
        {

            if (DDM.DraggingModes == DragDropManager.DragModes.DoNotChange)
            {
                SetMousePos();

                differenceX = thisRT.position.x - MousePos.x;
                differenceY = thisRT.position.y - MousePos.y;
            }

            PDown = true;
        }
        else
        {
            // Setup AI system
            float speed = DDM.GetComponent<AIManager>().MovementSpeed;

            for (int i = 0; i < DDM.AllPanels.Length; i++)
            {
                if (AIPanel == DDM.AllPanels[i].Id)
                {
                    StartCoroutine(SmoothMove(state, thisRT, DDM.AllPanels[i].GetComponent<RectTransform>().position, speed));
                }
            }
        }

        // Events Management
        if (OnBeginDragging != null)
        {
            OnBeginDragging.Invoke();
        }

        string PanelID = DragDropManager.GetObjectPanel(Id);
        switch (PanelID)
        {
            case "Inventory1":
                GameObject.Find("IconControl1").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory2":
                GameObject.Find("IconControl2").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory3":
                GameObject.Find("IconControl3").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory4":
                GameObject.Find("IconControl4").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory5":
                GameObject.Find("IconControl5").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory6":
                GameObject.Find("IconControl6").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory7":
                GameObject.Find("IconControl7").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory8":
                GameObject.Find("IconControl8").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory9":
                GameObject.Find("IconControl9").GetComponent<KnifeIcon>().Show = false;
                break;
            case "Inventory10":
                GameObject.Find("IconControl10").GetComponent<KnifeIcon>().Show = false;
                break;

        }

    }

    void SetMousePos()
    {
        Vector3 screenPoint;

        if (DDM.TargetPlatform == DragDropManager.Platforms.PC)
        {
            // for PC
            if (DDM.FirstCanvas.renderMode != RenderMode.ScreenSpaceOverlay)
            {
                // ScreenSpaceCamera & WorldSpace support
                screenPoint = Input.mousePosition;
                screenPoint.z = DDM.FirstCanvas.planeDistance;
                MousePos = Camera.main.ScreenToWorldPoint(screenPoint);
            }
            else
            {
                MousePos = Input.mousePosition;
            }
        }
        else
        {
            // for Mobile
            if (DDM.FirstCanvas.renderMode != RenderMode.ScreenSpaceOverlay)
            {
                // ScreenSpaceCamera & WorldSpace support
                screenPoint = Input.touches[0].position;
                screenPoint.z = DDM.FirstCanvas.planeDistance;
                MousePos = Camera.main.ScreenToWorldPoint(screenPoint);
            }
            else
            {
                MousePos = Input.touches[0].position;
            }
        }
    }

    public void PointerUp()
    {
        PointerUpActions();
    }

    void PointerUpActions()
    {
        if (Dropped)
        {
            // Setup customization tools of the panel
            int index = DDM.IdManager.IndexOf(Id);
            try
            {
                if (DDM.AllPanels[index].LockObject != PanelSettings.ObjectLockStates.LockObject)
                {
                    if (!LockObject || DDM.AllPanels[index].LockObject == PanelSettings.ObjectLockStates.DoNotLockObject)
                    {
                        CheckObjectPos();
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        else
        {
            CheckObjectPos();
        }
    }

    void CheckObjectPos()
    {
        PDown = false;
        CheckStatus = false;

        for (int i = 0; i < DDM.AllPanels.Length; i++)
        {

            if (RectTransformUtility.RectangleContainsScreenPoint(DDM.AllPanels[i].GetComponent<RectTransform>(), thisRT.position))
            {
                if (FilterPanels)
                {
                    // setup Filter Panels tool
                    if (Array.Exists(AllowedPanels, panel => panel == DDM.AllPanels[i].Id))
                    {
                        PanelDropTools(i);
                    }
                }
                else
                {
                    PanelDropTools(i);
                }
            }
        }

        if (!CheckStatus)
        { // check if drag & drop failed
            if (!ReturnSmoothly)
            {
                thisRT.position = CurrentPos;

                // Save last position of this object
                if (DDM.SaveStates)
                {
                    PlayerPrefs.SetFloat(Id + "X", CurrentPos.x);
                    PlayerPrefs.SetFloat(Id + "Y", CurrentPos.y);
                }
            }
            else
            {
                StartCoroutine(SmoothMove("User", thisRT, CurrentPos, ReturnSpeed));
            }

            thisRT.localScale = FirstScale;

            // Events Management
            if (OnDragDropFailed != null)
            {
                OnDragDropFailed.Invoke();
            }
        }

        thisRT.SetParent(thisParent);
    }

    void PanelDropTools(int i)
    {
        if (DDM.IdManager[i] != "" && DDM.IdManager[i] != Id)
        {

            for (int j = 0; j < DDM.AllObjects.Length; j++)
            {
                if (DDM.AllObjects[j].Id == DDM.IdManager[i])
                {
                    if (DDM.AllObjects[j].OnReturning)
                    {
                        return;
                    }
                }
            }
            // Setup customization tools of the panel
            if (DDM.AllPanels[i].ObjectReplacement != PanelSettings.ObjectReplace.NotAllowed)
            {
                CheckStatus = true;
                DropActions(i);
            }
        }
        else
        {
            CheckStatus = true;
            DropActions(i);
        }
    }

    void DropActions(int i)
    {
        bool SwitchStatus = false;
        bool ReplaceDefaultPanel = false;

        // setup ReturnObject tool
        ReturnObjectTool();

        thisRT.localScale = FirstScale;

        if (!StayDroppedPos && !ReturnObject && DDM.AllPanels[i].ObjectPosition != PanelSettings.ObjectPosStates.DroppedPosition)
        {
            thisRT.position = new Vector3(DDM.AllPanels[i].GetComponent<RectTransform>().position.x, DDM.AllPanels[i].GetComponent<RectTransform>().position.y, thisRT.position.z);
        }

        // Save last position of this object
        if (DDM.SaveStates)
        {
            PlayerPrefs.SetFloat(Id + "X", thisRT.position.x);
            PlayerPrefs.SetFloat(Id + "Y", thisRT.position.y);
        }

        // Check if there is another object on target panel
        if (DDM.IdManager[i] != "" && DDM.IdManager[i] != Id)
        {

            if (DDM.AllPanels[i].ObjectReplacement == PanelSettings.ObjectReplace.Allowed)
            {

                for (int j = 0; j < DDM.AllObjects.Length; j++)
                {
                    if (DDM.IdManager[i] == DDM.AllObjects[j].Id)
                    {
                        if (DDM.AllObjects[j].DefaultPanel)
                        {
                            ReplaceDefaultPanel = true;
                        }
                    }
                }

                // Check if objects should not switch between their panels. So this object will replace with second object
                if (!SwitchObjects && !DefaultPanel && !ReplaceDefaultPanel)
                {
                    ObjectsReplacement(i);
                }
                else
                {
                    // Objects will switch between their panels (if this object was on any panel)
                    if (ObjectsSwitching(i))
                    {
                        SwitchStatus = true;
                    }
                    else
                    {
                        // This object was not on any panel. So this object will be replaced with second object
                        ObjectsReplacement(i);
                    }
                }
            }
        }

        // setup Multi Object tool
        int index = DDM.IdManager.IndexOf(Id);

        try
        {
            if (DDM.AllPanels[index].ObjectReplacement == PanelSettings.ObjectReplace.MultiObjectMode && !SwitchStatus)
            {
                DDM.AllPanels[index].RemoveMultiObject(Id);
                SetPrevPanelId();
            }
            else if (DDM.AllPanels[index].ObjectReplacement == PanelSettings.ObjectReplace.MultiObjectMode)
            {
                SetPrevPanelId();
            }
        }
        catch { }


        if (DDM.AllPanels[i].ObjectReplacement == PanelSettings.ObjectReplace.MultiObjectMode)
        {
            SetPrevPanelId();
            DDM.AllPanels[i].SetMultiObject(Id);
        }

        // setup ScaleOnDropped tool
        ScaleOnDroppedTool();

        if (!SwitchObjects && !DefaultPanel)
        {
            SetPrevPanelId();
        }
        else
        {
            if (DDM.IdManager[i] == "")
            {
                SetPrevPanelId();
            }
        }

        DDM.SetPanelObject(i, Id);

        // Setup customization tools of the panel
        if (DDM.AllPanels[i].ObjectPosition == PanelSettings.ObjectPosStates.PanelPosition)
        {
            thisRT.position = new Vector3(DDM.AllPanels[i].GetComponent<RectTransform>().position.x, DDM.AllPanels[i].GetComponent<RectTransform>().position.y, thisRT.position.z);
        }
        //

        // Panel Events Management
        DDM.AllPanels[i].SetupPanelEvents();

        // Events Management
        if (OnDroppedSuccessfully != null)
        {
            OnDroppedSuccessfully.Invoke();
        }
    }

    void ObjectsReplacement(int i)
    {
        for (int j = 0; j < DDM.AllObjects.Length; j++)
        {

            if (DDM.IdManager[i] == DDM.AllObjects[j].Id && DDM.AllObjects[j].Dropped)
            {
                DDM.AllObjects[j].Dropped = false;

                DDM.AllObjects[j].GetComponent<RectTransform>().localScale = DDM.AllObjects[j].FirstScale;

                kitchen_UI.RemoveInventory(DDM.AllObjects[j].name);
                kitchen_UI.HideItem();

                if (!ReplaceSmoothly)
                {
                    DDM.AllObjects[j].GetComponent<RectTransform>().position = DDM.AllObjects[j].FirstPos;

                    // Save last position of second object
                    if (DDM.SaveStates)
                    {
                        PlayerPrefs.SetFloat(DDM.AllObjects[j].Id + "X", DDM.AllObjects[j].FirstPos.x);
                        PlayerPrefs.SetFloat(DDM.AllObjects[j].Id + "Y", DDM.AllObjects[j].FirstPos.y);
                    }
                }
                else
                {
                    StartCoroutine(SmoothMove("User", DDM.AllObjects[j].GetComponent<RectTransform>(), DDM.AllObjects[j].FirstPos, ReplacementSpeed));
                }
            }
        }
    }

    bool ObjectsSwitching(int i)
    {
        int index = DDM.IdManager.IndexOf(Id);

        try
        {
            for (int j = 0; j < DDM.AllObjects.Length; j++)
            {
                if (DDM.IdManager[i] == DDM.AllObjects[j].Id)
                {

                    if (DDM.AllPanels[index].ObjectReplacement == PanelSettings.ObjectReplace.MultiObjectMode)
                    {
                        // setup Multi Object tool
                        DDM.AllPanels[index].RemoveMultiObject(Id);
                        DDM.AllPanels[index].SetMultiObject(DDM.AllObjects[j].Id);
                    }

                    DDM.SetPanelObject(index, DDM.AllObjects[j].Id);

                    DDM.AllObjects[j].GetComponent<RectTransform>().SetAsLastSibling();

                    if (!MoveSmoothly)
                    {
                        DDM.AllObjects[j].GetComponent<RectTransform>().position = new Vector3(CurrentPos.x, CurrentPos.y, DDM.AllObjects[j].GetComponent<RectTransform>().position.z);

                        // Save last position of second object
                        if (DDM.SaveStates)
                        {
                            PlayerPrefs.SetFloat(DDM.AllObjects[j].Id + "X", CurrentPos.x);
                            PlayerPrefs.SetFloat(DDM.AllObjects[j].Id + "Y", CurrentPos.y);
                        }
                    }
                    else
                    {
                        StartCoroutine(SmoothMove("User", DDM.AllObjects[j].GetComponent<RectTransform>(), CurrentPos, MovementSpeed));
                    }
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    void SetPrevPanelId()
    {
        int index = DDM.IdManager.IndexOf(Id);

        try
        {
            if (DDM.AllPanels[index].ObjectReplacement != PanelSettings.ObjectReplace.MultiObjectMode || DDM.AllPanels[index].PanelIdManager.Count == 0)
            {
                DDM.SetPanelObject(index, "");
            }
            else
            {
                DDM.SetPanelObject(index, DDM.AllPanels[index].PanelIdManager[DDM.AllPanels[index].PanelIdManager.Count - 1]);
            }
        }
        catch { }
    }

    void ReturnObjectTool()
    {
        if (!ReturnObject)
        {
            Dropped = true;
        }
        else
        {
            thisRT.position = CurrentPos;
        }
    }

    void ScaleOnDroppedTool()
    {
        if (Dropped && ScaleOnDropped)
        {
            thisRT.localScale = DropScale;
        }
    }

    // Smooth Movement tool
    IEnumerator SmoothMove(string state, RectTransform Target, Vector3 TargetPos, float Speed)
    {
        Target.GetComponent<ObjectSettings>().OnReturning = true;

        float t = 0.0f;

        TargetPos.z = Target.position.z;

        // Save last position of target object
        if (DDM.SaveStates)
        {
            PlayerPrefs.SetFloat(Target.GetComponent<ObjectSettings>().Id + "X", TargetPos.x);
            PlayerPrefs.SetFloat(Target.GetComponent<ObjectSettings>().Id + "Y", TargetPos.y);
        }

        while (!Mathf.Approximately(Target.position.x, TargetPos.x) || !Mathf.Approximately(Target.position.y, TargetPos.y))
        {
            t += Time.deltaTime * Speed;

            Target.position = Vector3.Lerp(Target.position, TargetPos, Mathf.SmoothStep(0.0f, 1.0f, t));

            yield return null;
        }

        Target.GetComponent<ObjectSettings>().OnReturning = false;

        if (state == "AI")
        {
            PointerUp();
        }
    }



    public void IconOnDrop()
    {
        switch (Id)
        {
            case "Carrot1":
            case "Carrot2":
            case "Carrot3":
            case "Carrot4":
            case "CutedCarrot1_Step1":
            case "CutedCarrot2_Step1":
            case "CutedCarrot3_Step1":
            case "CutedCarrot4_Step1":
            case "Beef1":
            case "Beef2":
            case "Beef3":
            case "Beef4":
            case "Chicken1":
            case "Chicken2":
            case "Chicken3":
            case "Chicken4":
            case "ChineseKale1":
            case "ChineseKale2":
            case "ChineseKale3":
            case "ChineseKale4":
            case "Cucumber1":
            case "Cucumber2":
            case "Cucumber3":
            case "Cucumber4":
            case "Fish1":
            case "Fish2":
            case "Fish3":
            case "Fish4":
            case "Garlic1":
            case "Garlic2":
            case "Garlic3":
            case "Garlic4":
            case "Ginger1":
            case "Ginger2":
            case "Ginger3":
            case "Ginger4":
            case "CutedGinger1_Step1":
            case "CutedGinger2_Step1":
            case "CutedGinger3_Step1":
            case "CutedGinger4_Step1":
            case "Lime1":
            case "Lime2":
            case "Lime3":
            case "Lime4":
            case "CutedLime1_Step1":
            case "CutedLime2_Step1":
            case "CutedLime3_Step1":
            case "CutedLime4_Step1":
            case "Onion1":
            case "Onion2":
            case "Onion3":
            case "Onion4":
            case "CutedOnion1_Step1":
            case "CutedOnion2_Step1":
            case "CutedOnion3_Step1":
            case "CutedOnion4_Step1":
            case "Pork1":
            case "Pork2":
            case "Pork3":
            case "Pork4":
            case "Potato1":
            case "Potato2":
            case "Potato3":
            case "Potato4":
            case "Shallot1":
            case "Shallot2":
            case "Shallot3":
            case "Shallot4":
            case "CutedShallot1_Step1":
            case "CutedShallot2_Step1":
            case "CutedShallot3_Step1":
            case "CutedShallot4_Step1":
            case "SpringOnion1":
            case "SpringOnion2":
            case "SpringOnion3":
            case "SpringOnion4":
            case "CutedSpringOnion1_Step1":
            case "CutedSpringOnion2_Step1":
            case "CutedSpringOnion3_Step1":
            case "CutedSpringOnion4_Step1":
            case "Tomato1":
            case "Tomato2":
            case "Tomato3":
            case "Tomato4":
                SetToShow();
                break;
        }
 
    }

    void SetToShow()
    {
        string PanelID = DragDropManager.GetObjectPanel(Id);

        switch (PanelID)
        {
            case "Inventory1":
                GameObject.Find("IconControl1").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory2":
                GameObject.Find("IconControl2").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory3":
                GameObject.Find("IconControl3").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory4":
                GameObject.Find("IconControl4").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory5":
                GameObject.Find("IconControl5").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory6":
                GameObject.Find("IconControl6").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory7":
                GameObject.Find("IconControl7").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory8":
                GameObject.Find("IconControl8").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory9":
                GameObject.Find("IconControl9").GetComponent<KnifeIcon>().Show = true;
                break;
            case "Inventory10":
                GameObject.Find("IconControl10").GetComponent<KnifeIcon>().Show = true;
                break;
        }
    }
}