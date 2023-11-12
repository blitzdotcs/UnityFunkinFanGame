using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMHandler: MonoBehaviour {

	public float bpm;
	public bool songStarted;

	// Use this for initialization
	void Start () {
		bpm = bpm / 60f;
	}
	
	// Update is called once per frame
	void Update () {
		if(!songStarted)
		{
			/*
			if(Input.anyKeyDown)
			{
				songStarted = true;
			}
			*/
		}
		else
		{
			transform.position += new Vector3(0f, bpm * Time.deltaTime, 0f);
		}
	}
}
