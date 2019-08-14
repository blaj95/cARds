using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * .5f * Time.deltaTime);
    }

    public void GetRekd()
    {
        FindObjectOfType<GameManager>().score += 1;
        Destroy(gameObject,.2f);
    }
}
