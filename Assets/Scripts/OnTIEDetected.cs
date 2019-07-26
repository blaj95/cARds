using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnTIEDetected : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour stormTrooperCard;
    public Explode explode;
    public Explode explode2;
    public AudioSource roar;
    public AudioSource march;
    public Animator anim;

    public GameObject flyingTIE;

    public GameObject tiePrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (stormTrooperCard)
        {
            stormTrooperCard.RegisterTrackableEventHandler(this);
        }
    }


    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        Debug.Log(stormTrooperCard.transform.position);
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            march.Play();
            //roar.Play();
            anim.SetBool("Fly", true);
            Debug.Log("bleg");
            flyingTIE = Instantiate(tiePrefab, Vector3.zero, Quaternion.identity) as GameObject;
        }

        if (newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            anim.SetBool("Fly", false);
            Debug.Log("MERh");
            Destroy(flyingTIE);
        }
    }

    public void StartCo()
    {
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {

        yield return new WaitForSeconds(2);
        explode.explosion.SetActive(false);
        explode.gameObject.SetActive(true);
    }

    public void StartCo2()
    {
        StartCoroutine(Respawn2());
    }

    IEnumerator Respawn2()
    {
        yield return new WaitForSeconds(2);
        explode2.explosion.SetActive(false);
        explode2.gameObject.SetActive(true);
        explode2.tieAnim.SetBool("Fly",true);
    }
}
