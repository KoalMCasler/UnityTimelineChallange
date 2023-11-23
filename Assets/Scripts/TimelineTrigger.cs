using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public GameObject timeline;
    void start()
    {
        //timeline.GetComponent<PlayableDirector>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timeline.GetComponent<PlayableDirector>().Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
         if(other.CompareTag("Player"))
        {
            (timeline.GetComponent<PlayableDirector>()).Stop();
        }
    }
}
