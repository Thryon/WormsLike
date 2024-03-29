﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazookaProjectile : ExplosiveProjectile {

    private new void Start()
    {
        base.Start();
        Destroy(gameObject, 10.0f);
    }

    protected void FixedUpdate()
    {
        if (!isActive)
            return;
        if (rb.velocity.magnitude > 0.1f)
        {
            transform.LookAt(transform.position + rb.velocity);
        }
    }

    public override void Explode()
    {
        base.Explode();
        isActive = false;
        transform.GetChild(0).gameObject.SetActive(false);
        Destroy(gameObject, 2.5f);
        GetComponent<Collider>().enabled = false;
        Destroy(GetComponent<Collider>());
        Destroy(GetComponent<ConstantForce>());
        Destroy(GetComponent<Rigidbody>());
    }
}
