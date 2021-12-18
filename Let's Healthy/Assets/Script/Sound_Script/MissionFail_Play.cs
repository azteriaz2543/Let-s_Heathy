using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFail_Play : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Sound_Manager.PlaySound(Sound_Manager.Sound.MissionFail);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
