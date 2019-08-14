using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLaser : MonoBehaviour
{
    public float speed;
    public GameObject explosion;
    public GameObject largerExplosion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("hit");
        if (other.transform.CompareTag("Destroy"))
        {
            ContactPoint contactPoint = other.contacts[0];
            Instantiate(explosion, contactPoint.point, explosion.transform.rotation);
            Destroy(gameObject);
        }
        else if(other.transform.CompareTag("TIE"))
        {
           //other.gameObject.Explosion();
           Destroy(gameObject);
        }
        else if (other.transform.CompareTag("Start"))
        {
            ContactPoint contactPoint = other.contacts[0];
            Instantiate(explosion, contactPoint.point, explosion.transform.rotation);
            GameManager manager = FindObjectOfType<GameManager>();
            if (!manager.started)
                manager.started = true;
            Destroy(gameObject);
        }
        else if (other.transform.CompareTag("Trooper"))
        {
            ContactPoint contactPoint = other.contacts[0];
            Instantiate(explosion, contactPoint.point, explosion.transform.rotation);
            other.gameObject.GetComponentInChildren<Animator>().enabled = false;
            if(!other.gameObject.GetComponent<Troopermove>().dead == true)
                other.gameObject.GetComponent<Troopermove>().GetRekd();
            other.gameObject.GetComponent<Troopermove>().dead = true;
            Destroy(gameObject);
        }
        else if (other.transform.CompareTag("TIEFighter"))
        {
            ContactPoint contactPoint = other.contacts[0];
            if(!other.gameObject.GetComponent<Fly>().dead == true)
                Instantiate(largerExplosion, contactPoint.point, explosion.transform.rotation);
            if(!other.gameObject.GetComponent<Fly>().dead == true)
                other.gameObject.GetComponent<Fly>().GetRekd();
            other.gameObject.GetComponent<Fly>().dead = true;
        }
    }
}
