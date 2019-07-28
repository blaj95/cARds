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
        Vector3 pos = new Vector3(x,.4f,z);
        transform.localPosition = pos;
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(pos),.15f);
    }
}
