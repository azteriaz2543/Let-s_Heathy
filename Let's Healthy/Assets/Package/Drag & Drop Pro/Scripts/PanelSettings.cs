using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class PanelSettings : MonoBehaviour {
	DragDropManager DDM;
	
	// the Id of this panel
	public string Id;

	// Enums
	public enum ObjectPosStates { UseObjectSettings, DroppedPosition, PanelPosition };
	public enum ObjectLockStates { UseObjectSettings, LockObject, DoNotLockObject  };
	public enum ObjectReplace { Allowed, NotAllowed, MultiObjectMode  };
	//

	// Customization Tools
	[Header ("Object Position")]
	[Tooltip ("Customize the position of object when dropped on this panel")]
	public ObjectPosStates ObjectPosition;

	[Header ("Lock Object")]
	[Tooltip ("Customize Object Locking")]
	public ObjectLockStates LockObject;

	[Header ("Replacement & Multi Object")]
	[Tooltip ("Allow Object to Replace & Switch or use Multi Object Mode")]
	public ObjectReplace ObjectReplacement;
	//

	[Header ("Events Management")]
	[Tooltip ("When any object dropped on the panel, the functions that you added to this event trigger will be called")]
	public UnityEvent OnObjectDropped;

	[HideInInspector]
	// using for Multi Object tool
	public List<string> PanelIdManager;

    Kitchen_UI kitchen_UI;
    public string currentItem;
    Cooking cooking;

    

    void Start () {
		// Getting current DDM GameObject
		DDM = GameObject.Find ("DDM").GetComponent<DragDropManager> ();

        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();

    }

	public void SetupPanelEvents () {
		// Events Management
		if (OnObjectDropped != null) {
			OnObjectDropped.Invoke ();
		}
	}

	public void SetMultiObject (string ObjectId) {
		// Adding new object to the list of dropped objects
		PanelIdManager.Add (ObjectId);

		if (DDM.SaveStates) {
			SaveObjectsList ();
		}
	}

    public void AddItem()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);

        if (currentItem != ObjectId)
        {
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
            
            if (ObjectId == "Spoon" || ObjectId == "Turner" || ObjectId == "Rice")
            {
                ReturnItem.SetActive(true);
            }
            else
            {
                ReturnItem.SetActive(false);
            }
        }  

    }

    public void RemoveMultiObject (string ObjectId) {
		// Removing an object from list of dropped objects
		if (DDM.SaveStates) {
			PlayerPrefs.DeleteKey (Id + "&&" + (PanelIdManager.Count - 1).ToString ());
		}

		PanelIdManager.Remove (ObjectId);
	}

	void SaveObjectsList () {
		for (int i = 0; i < PanelIdManager.Count; i++) {
			PlayerPrefs.SetString (Id + "&&" + i.ToString (), PanelIdManager [i]);
		}
	}

	public void LoadObjectsList () {
		// loading list of dropped objects
		for (int i = 0; i < DragDropManager.DDM.AllObjects.Length; i++) {
			if (PlayerPrefs.HasKey (Id + "&&" + i.ToString ())) {
				PanelIdManager.Add (PlayerPrefs.GetString (Id + "&&" + i.ToString ()));
			}
		}

		for (int i = 0; i < PanelIdManager.Count; i++) {
			for (int j = 0; j < DragDropManager.DDM.AllObjects.Length; j++) {
				
				if (DragDropManager.DDM.AllObjects [j].Id == PanelIdManager [i]) {
					DragDropManager.DDM.AllObjects [j].GetComponent <RectTransform> ().SetAsLastSibling ();

					for (int k = 0; k < DragDropManager.DDM.AllPanels.Length; k++) {
						if (DragDropManager.DDM.AllPanels [k].Id == Id) {
							DragDropManager.DDM.SetPanelObject (k, DragDropManager.DDM.AllObjects [j].Id);
						}
					}
				}
			}
		}
	}

    bool haveKnife = false;
    bool canCut = false;

    public void CheckForCut()
    {

        string ObjectId = DragDropManager.GetPanelObject(Id);
        if (currentItem != ObjectId)
        {
            currentItem = ObjectId;
        }

        if (currentItem == "Knife1")
        {
            haveKnife = true;
            DragDropManager.ResetOnlyObject("Knife1");
        }

        if (haveKnife == true)
        {
            for (int i = 0; i < PanelIdManager.Count; i++)
            {
                switch (PanelIdManager[i])
                {
                    default: canCut = false;
                        break;
                    case "Carrot1": 
                        canCut = true;
                        break;
                    case "Carrot2":
                        canCut = true;
                        break;
                    case "Carrot3":
                        canCut = true;
                        break;
                    case "Carrot4":
                        canCut = true;
                        break;
                    case "CutedCarrot1_Step1":
                        canCut = true;
                        break;
                    case "CutedCarrot2_Step1":
                        canCut = true;
                        break;
                    case "CutedCarrot3_Step1":
                        canCut = true;
                        break;
                    case "CutedCarrot4_Step1":
                        canCut = true;
                        break;
                }

                if (canCut == true && kitchen_UI.Cuting == true)
                {
                    cooking.SpawnCutedItem(PanelIdManager[i]);
                    DragDropManager.ResetOnlyObject(PanelIdManager[i]);
                    kitchen_UI.RemoveInventory(PanelIdManager[i]);
                    break;
                }
            }

                haveKnife = false;
                PanelIdManager.Clear();
                


        }


    }

    public void SpawnItem()
    {
        string ObjectId = DragDropManager.GetPanelObject(Id);
        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();

        if (ObjectId == "Spoon" || ObjectId == "Turner")
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
            kitchen_UI.RemoveInventory(ObjectId);
        }

        Return();

        
    }

}