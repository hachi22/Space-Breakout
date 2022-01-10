﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.collider.CompareTag("Bullet")))
        {
            Destroy(gameObject);
        }
      
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!(collision.collider.CompareTag("Bullet")))
        {
            print("entrando2");
            Destroy(gameObject);
        }
    }


}
