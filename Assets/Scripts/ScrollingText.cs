using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
    private Transform textPos;
    public GameManager manager;
    public float speed;

    public bool winningText;

    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        textPos = GetComponent<Transform>();
        StartCoroutine(DestroyThis());
    }

    private IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(11);
        if(!winningText)
            manager.EnableSpawns();
        if(winningText)
            restart.SetActive(true);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localUp = transform.worldToLocalMatrix.MultiplyVector(transform.up);
        transform.Translate(localUp * speed * Time.deltaTime);
    }

 
}
