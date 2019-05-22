using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour {
    public GameObject avatar;
    public Text location;
    // Use this for initialization
    void Start () {
        avatar.SetActive(false);
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            avatar.SetActive(true);
            avatar.transform.position = new Vector2(540 + 125, 960 - 165);
            location.text = "Current Location: Community Hub – Block A";

        }

        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            avatar.SetActive(true);
            avatar.transform.position = new Vector2(540 + 400, 960 - 45);
            location.text = "Current Location: Nursing Home – Block B";
        }

        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            avatar.SetActive(true);
            avatar.transform.position = new Vector2(540, 960 + 350);
            location.text = "Current Location: KWSH Heritage Gallery";
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            avatar.SetActive(true);
            avatar.transform.position = new Vector2(540 + 45, 960 + 110);
            location.text = "Current Location: The Garden Pavillion";
        }
    }

    // Update is called once per frame
    void Update () {
    }
}
