using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject laser;
    public Transform firePoint1;
    public Transform firePoint2;
    public AudioSource blast;
    
    public void FireLaser()
    {
        GameObject _laser = Instantiate(laser, firePoint1.transform.position, firePoint1.transform.rotation);
        GameObject _laser2 = Instantiate(laser, firePoint2.transform.position, firePoint2.transform.rotation);
        blast.Play();
    }

   
}
