using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrooperSpawn : MonoBehaviour
{
    public GameObject trooper;

    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        if(right)
            InvokeRepeating("Spawn",2f,2.33f);
        else
        {
            InvokeRepeating("Spawn",3f,2f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject troop = Instantiate(trooper, transform.position, transform.rotation,gameObject.transform);
    }
}
