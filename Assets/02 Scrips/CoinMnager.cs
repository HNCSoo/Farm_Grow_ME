using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinMnager : MonoBehaviour
{
    public static int  coin;
   // Text text;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
        text = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = coin + " $ " ;
    }
    
}
