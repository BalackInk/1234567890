using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huixuanbiao : MonoBehaviour {
    public GameObject HXB;
    Collider2D HXBcoll;

    // Use this for initialization
    void Start () {
        HXBcoll = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "you")
        {
            collision.GetComponent<You>().SetTools(0, true);
        }
        Destroy (HXB); 
    }
}
