using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troopermove : MonoBehaviour
{
    public bool right;

    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        if (!right)
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        StartCoroutine("AutoKill");
    }

    // Update is called once per frame
    void Update()
    {
        if(right)
            transform.Translate(Vector3.right * .19f * Time.deltaTime);
        else
        {
            transform.Translate(-Vector3.right * .19f * Time.deltaTime);
        }

        if (dead && right)
        {
            transform.Rotate(Vector3.forward * 245 * Time.deltaTime);
        }
        else if (dead && !right)
        {
            transform.GetChild(0).Rotate(-Vector3.forward * 245 * Time.deltaTime);
        }
    }

    public void GetRekd()
    {
        FindObjectOfType<GameManager>().score += 1;
        StopAllCoroutines();
        Destroy(gameObject,1.5f);
    }

    IEnumerator AutoKill()
    {
        yield return  new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
