using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalMove : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    float speed = 1f;
    Rigidbody PlayerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
      //   var  target = GameObject.FindGameObjectWithTag("Feed").transform;
         agent = GetComponent<NavMeshAgent>();
        PlayerRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        var feedObj = GameObject.FindGameObjectWithTag("Feed");
        if (feedObj == null) return;
        var target = feedObj.transform;

        Vector3 dir = target.transform.position - transform.position;
     
        gameObject.transform.position += dir * speed * Time.deltaTime;
        
            
        Quaternion newRotation = Quaternion.LookRotation(dir);
        PlayerRigidbody.MoveRotation(newRotation);
        //agent.SetDestination(target.position);

       
    }
}
