using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShoot : MonoBehaviour
{
    public GameObject Rocket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyDown("f"))
            {
            Instantiate(Rocket, transform.position, transform.rotation);
            }
    }
}
