using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
    private Transform textPos;
    // Start is called before the first frame update
    void Start()
    {
        textPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localUp = transform.worldToLocalMatrix.MultiplyVector(transform.up);
        transform.Translate(localUp * .001f * Time.deltaTime);
    }
}
