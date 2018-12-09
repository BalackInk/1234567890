using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jianjiaoji : MonoBehaviour {
    public GameObject JJJ;
    Collider2D JJJcoll;

    
    // Use this for initialization
    void Start () {
        //transform.Rotate(new Vector3(2, 3, 4), 90);
        JJJcoll = GetComponent<Collider2D>();
        

    }
	
	// Update is called once per frame
	void Update () {
       


	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "you")
        {
            collision.GetComponent<You>().SetTools(1, true);
        }
        Destroy(JJJ);
    }



}
