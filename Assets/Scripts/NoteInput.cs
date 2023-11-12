using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInput : MonoBehaviour {

    private SpriteRenderer SR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode reginput;
    public KeyCode arrowinput;

    void Start ()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    void Update () {
        if(Input.GetKeyDown(reginput))
        {
            SR.sprite = pressedImage;
        }

        if(Input.GetKeyUp(reginput))
        {
            SR.sprite = defaultImage;
        }
        // arrow key input
        if(Input.GetKeyDown(arrowinput))
        {
            SR.sprite = pressedImage;
        }

        if(Input.GetKeyUp(arrowinput))
        {
            SR.sprite = defaultImage;
        }          
    }

}