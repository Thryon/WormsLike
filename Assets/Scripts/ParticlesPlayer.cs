﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesPlayer : MonoBehaviour {

	public void Play()
    {
        GetComponent<ParticleSystem>().Play();
    }
}
