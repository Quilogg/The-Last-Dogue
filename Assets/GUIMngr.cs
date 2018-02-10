using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GUIMngr : MonoBehaviour {
    public EventSystem ES;
    private GameObject SG;
    // Use this for initialization
    void Start () {
        SG = ES.firstSelectedGameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (ES.currentSelectedGameObject != SG)
        {
            if (ES.currentSelectedGameObject == null)

                ES.SetSelectedGameObject(SG);
            else
                SG = ES.currentSelectedGameObject;
        }
    }
}
