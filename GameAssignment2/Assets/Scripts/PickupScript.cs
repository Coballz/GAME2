using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player") {
            Destroy(gameObject);
            col.gameObject.tag = "HasOrb";
        }
    }
}
