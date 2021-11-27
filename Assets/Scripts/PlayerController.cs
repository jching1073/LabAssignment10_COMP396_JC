using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    //bullets prefab
    float speed = 3f; // m/s
    float angularSpeed = 120; // deg/sec

    public override void OnStartLocalPlayer()
    {
        //base.OnStartLocalPlayer();
        GetComponent<Renderer>().material.color = Color.blue;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isLocalPlayer)
        {
            return; // we handle only local player commands
        }

        //local player ; handle input
        var h = Input.GetAxis("Horizontal"); //h is [-1, 1]
        var v = Input.GetAxis("Vertical"); //v is in [-1, 1]
        transform.Rotate(0, h * Time.deltaTime * angularSpeed, 0); //abrupt rotation
        transform.Translate(0, 0, v * Time.deltaTime * speed);
        float f = Input.GetAxis("Fire1");
        if(f> 0.9)
        {
            print("FS " + f);
        }
        
        //if(Input.GetAxis("Fire1"))
        //{

        // }
    }
}
