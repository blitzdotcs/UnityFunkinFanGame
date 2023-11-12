using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHandler : MonoBehaviour {

	public bool canbePressed;
    public KeyCode reginput;
    public KeyCode arrowinput;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(reginput) || Input.GetKeyDown(arrowinput))
        {
            if(canbePressed)
			{
				gameObject.SetActive(false);
				SongManager.instance.NoteHit();
			}
        }	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Activator")
		{
			canbePressed = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Activator")
		{
			canbePressed = false;
			SongManager.instance.NoteMiss();
		}
	}			
}
