using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    public OnTIEDetected onTIE;
    public Animator tieAnim;
    public void Explosion()
    {
        explosion.SetActive(true);
        onTIE.StartCo();
        gameObject.SetActive(false);
    }

    public void Explosion2()
    {
        explosion.SetActive(true);
        onTIE.StartCo2();
        tieAnim.SetBool("Fly",false);
        gameObject.SetActive(false);
        gameObject.transform.position = new Vector3(10000,10000,1000);
    }
}
