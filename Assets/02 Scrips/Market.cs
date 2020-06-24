using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    int CoinValue = 100;
    GameObject cow;
    AudioSource Cowaudio;


    // Start is called before the first frame update
    void Start()
    {
        GameObject cow = GameObject.Find("CowBlW 1");
        Cowaudio = cow.GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void CoinUp()
    {
        GameObject cow = GameObject.Find("CowBlW 1");


        if (cow.transform.localScale.x >=5 && cow.transform.localScale.y >= 5 && cow.transform.localScale.z >= 5)
        {
            

            CoinMnager.coin += CoinValue;
            print("coin");
        }

        cow.transform.localScale = new Vector3(2,2,2);
        Cowaudio.Play();

        print("사이즈업 ");


      

    }
}
