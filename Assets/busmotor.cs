using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class busmotor : MonoBehaviour
{
    private float speed = 5.0f;
    public GameObject Player;

    void Start()
    {
        transform.position = (new Vector3(2.91f, 1.89f, .16f));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.position = (new Vector3(transform.position.x, transform.position.y, Player.transform.position.z));
    }
    
}

