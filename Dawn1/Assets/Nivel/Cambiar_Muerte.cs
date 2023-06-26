using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Cambiar_Muerte : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
