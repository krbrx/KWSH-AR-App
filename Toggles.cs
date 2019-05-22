using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Toggles : MonoBehaviour {
    bool resultBool;
    public GameObject resultGrp;
    public Text cam;

    public void ToggelAR()
    {
        if (!resultBool)
        {
            VuforiaBehaviour.Instance.enabled = false;
            resultBool = true;
            resultGrp.SetActive(true);
        }

        else
        {
            VuforiaBehaviour.Instance.enabled = true;
            resultBool = false;
            resultGrp.SetActive(false);
        }
    }

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        if (!resultBool)
        {
            cam.text = "";
        }
        else
        {
            cam.text = "Camera is not switch on";
        }
    }
}
