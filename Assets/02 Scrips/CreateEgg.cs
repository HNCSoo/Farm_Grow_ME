using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEgg : MonoBehaviour
{   
    public GameObject chick;
    public static int babycount = 0;
    int maxbabycount = 3;
    float CreateBetweenTime = 3;
    float timer;
    Transform Mama;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Mama = GameObject.Find("Chicken _Mama").GetComponent<Transform>();
        audio = chick.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        timer += Time.deltaTime;
        if (other.transform.tag == "Mama" && babycount < maxbabycount) // && timer >= CreateBetweenTime
        {

            MakeChik();

         


            //  Invoke("MakeChik", 2);
        }

        
       
    }

    void MakeChik()
    {

     //   GameObject baby = Instantiate(chick);
        GameObject baby = Instantiate(chick, Mama.transform); // 생성될때 "Chicken _Mama"의 자식으로 생성됨
        babycount ++;
        audio.Play();
        print(babycount);

        baby.transform.position = transform.position;

        

    }

  
}
