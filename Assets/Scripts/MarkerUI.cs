using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerUI : MonoBehaviour
{
    public GameObject UIBeach;
    private GameObject model = null;
    private bool info = false;
    private bool audioOnOff = false;

    private void Start()
    {
#if !UNITY_EDITOR
        UIBeach.SetActive(false);
#endif
    }
    // Update is called once per frame
    void Update()
    {
        if(model == null)
        {
            model = GameObject.FindGameObjectWithTag("BEACH");
        }
    }

    public void TurnLeft()
    {
        //if(model != null)
        {
            model.GetComponent<Transform>().Rotate(new Vector3(15, 0, 0));
        }
        
    }
    public void TurnRight()
    {
        //if (model != null)
        {
            model.GetComponent<Transform>().Rotate(new Vector3(0, 15, 0));
        }
            
    }
    public void DisplayInfo()
    {
        info = !info;
        model.GetComponentInChildren<Canvas>().enabled = info;
    }
    public void PlayAudio()
    {
        audioOnOff = !audioOnOff;
        if (audioOnOff)
        {
            model.GetComponentInChildren<AudioSource>().Play();
        }
        else if (audioOnOff)
        {
            model.GetComponentInChildren<AudioSource>().Stop();
        }
    }
}
