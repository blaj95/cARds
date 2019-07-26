using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLaser : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * Time.deltaTime * speed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
        else if(other.transform.CompareTag("TIE"))
        {
           other.GetComponent<Explode>().Explosion();
           Destroy(gameObject);
        }
        else if (other.transform.CompareTag("TIE2"))
        {
            other.GetComponent<Explode>().Explosion2();
        }
    }
}
