using UnityEngine;
using System.Collections;

public class Pausa : MonoBehaviour {
    private bool pause=false;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.P)&& pause==false)
        {
            pause = true;
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.Escape) && pause == true)
        {
            pause = false;
            Time.timeScale = 1;
        }
    }
}
