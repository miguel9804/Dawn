using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
    public GameObject Boss;
    public Transform pos_i;
    public Transform pos_f;
    private Transform pos_s;
    public float velocidad;
    // Use this for initialization
    void Start () {
        pos_s = pos_f;
    }
	
	// Update is called once per frame
	void Update () {
        Boss.transform.position = Vector2.MoveTowards(Boss.transform.position, pos_s.position, Time.deltaTime * velocidad);
        if(Boss.transform.position == pos_s.position)
        {
            pos_s = pos_i;

        }
	}
}
