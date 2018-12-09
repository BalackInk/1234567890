using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour {
    public GameObject NEED;
    Collider2D NEEDcoll;




    // Use this for initialization
    void Start () {
        NEEDcoll = GetComponent<Collider2D>();



    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "you")
        {
            collision.GetComponent<You>().SetTools(2, true);
        }
        Destroy(NEED);
    }




}
