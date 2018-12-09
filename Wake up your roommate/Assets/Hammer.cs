using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    public GameObject HAMMER;
    Collider2D HAMMERcoll;

    // Use this for initialization
    void Start () {
        HAMMERcoll = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "you")
        {
            collision.GetComponent<You>().SetTools(3, true);
        }
        Destroy(HAMMER);
    }



   }
