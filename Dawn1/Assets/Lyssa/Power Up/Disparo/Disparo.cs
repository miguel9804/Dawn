using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {
    public GameObject player;
    private Transform playerTrans;
    public GameObject Bala;
    public float balaLife;

    
    public float speed;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTrans = player.transform;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject newBala = Instantiate(Bala, transform.position, transform.rotation) as GameObject;
            if (playerTrans.localScale.x > 0)
            {

                newBala.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            }
            else
            {
                newBala.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            }
            Destroy(newBala.gameObject, balaLife);
        }

    }
}
