using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StormTrooperCard : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour stormTrooperCard;

    public GameObject startingUI;

    public GameObject fireButton;

    public AudioSource march;
    // Start is called before the first frame update
    void Start()
    {
        if (stormTrooperCard)
        {
            stormTrooperCard.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            if (startingUI.activeSelf)
            {
                startingUI.SetActive(false);
            }

            if (!fireButton.activeSelf)
            {
                fireButton.SetActive(true);
            }

            if (!march.isPlaying)
            {
                march.Play();
            }
        }

        if (newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            
        }
    }
}
