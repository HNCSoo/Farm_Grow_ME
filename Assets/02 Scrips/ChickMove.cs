using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickMove : MonoBehaviour
{
    public GameObject target;
    Rigidbody chickRigidbody;
    float speed = 1f;
    float Chickspeed = 2f;
    float Chickspeed2 = 3;
    float Chickspeed3 = 5f;
    float Chickspeed4 = 15f;
    Animator anim;
    int CoinValue = 20;
    //maxsize = Vector3 (2,2,2);
    // Start is called before the first frame update
    void Start()
    {
        chickRigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var feedObj = GameObject.FindGameObjectWithTag("ChickFeed");
        if (feedObj == null) return;
        var target = feedObj.transform;

        Vector3 dir = target.transform.position - transform.position;

        gameObject.transform.position += dir * speed * Time.deltaTime;


        Quaternion newRotation = Quaternion.LookRotation(dir);
        chickRigidbody.MoveRotation(newRotation);

           if(Input.GetMouseButtonDown(0) && tag == "Chick")
           {
             CoinMnager.coin += CoinValue;
             Destroy(gameObject);
             CreateEgg.babycount = 0;
           }
        //agent.SetDestination(target.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.tag == "ChickFeed")
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Eat", true);
            //gameObject.transform.localScale = Vector3.Lerp(transform.localScale,transform.localScale *2 ,Chickspeed*Time.deltaTime);
           //Invoke("sizeup1",3);
           //Invoke("sizeup2",6);

        
        }
    }

    void sizeup1()
    {
         gameObject.transform.localScale = Vector3.Lerp(transform.localScale,transform.localScale *2 ,Chickspeed2*Time.deltaTime);
    }
    void sizeup2()
    {
         gameObject.transform.localScale = Vector3.Lerp(transform.localScale,transform.localScale *2 ,Chickspeed3*Time.deltaTime);
    }

   
}
