using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour {
    public PlayerController Heroe;
    public GameObject barra_vida;
    private Animator anim;
    private const string ESTADOS_VIDAS = "Vidas";

	// Use this for initialization
	void Start () {
        anim = barra_vida.GetComponent<Animator>();



	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger(ESTADOS_VIDAS, Heroe.Vidas);
	}
    
}
