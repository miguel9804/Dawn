using UnityEngine;
using System.Collections;

public class Vida_Boss : MonoBehaviour {
    public Boss boss;
    public GameObject vidas_boss;
    private Animator anim;
    public const string ESTADO_VIDAS_BOSS = "Vidas_Boss";
    
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

	
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger(ESTADO_VIDAS_BOSS,boss.Vidas_boss);
	}
}
