using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDay : MonoBehaviour
{
    Player player;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (player.day > 7)
        {
            Destroy(gameObject);
        }
        else if (player.day <= 7)
        {
            StartCoroutine(delay());
        }
        
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.01f);
        text.text = "วันที่ " + player.day + " .....";
    }

}
