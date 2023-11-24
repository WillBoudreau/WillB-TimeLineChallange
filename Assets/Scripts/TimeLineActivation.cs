using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineActivation : MonoBehaviour
{
    public PlayableDirector TimeLine;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        TimeLine.Play();
    }
}
