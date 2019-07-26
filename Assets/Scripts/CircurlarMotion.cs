using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircurlarMotion : MonoBehaviour
{
    public float timeCounter;
    
    public float speed;

    public float width;

    public float height;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;

        float x = Mathf.Cos(timeCounter);
        float z = Mathf.Sin(timeCounter);
        transform.localPosition = new Vector3(x,.4f,z);
        
        transform.Rotate(-transform.up,.96f);
    }
}
