using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIEfighterSpawn : MonoBehaviour
{
    public bool right;
    public GameObject tieFighter;
    // Start is called before the first frame update
    void Start()
    {
        if(right)
            InvokeRepeating("Spawn",2,3.5f);
        else
            InvokeRepeating("Spawn",3,4.25f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(tieFighter, transform.position, transform.rotation,gameObject.transform);
    }
}
