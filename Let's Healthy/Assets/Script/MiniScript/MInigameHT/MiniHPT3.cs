using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniHPT3 : MonoBehaviour
{
    [SerializeField] Text miniGameHPT3text,bB;
    int c_random;
    [SerializeField]InputField inputField;
    string a;

    // Start is called before the first frame update
    void Start()
    {
        c_random = Random.Range(32, 40);
    }

    // Update is called once per frame
    void Update()
    {
        a=inputField.text;
        print(a);
        if (int.Parse(a) ==c_random)
        {
            bB.text = "เสร็จแล้วโว้ย";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        miniGameHPT3text.text = c_random.ToString();
        print("c_random");
    }
}
