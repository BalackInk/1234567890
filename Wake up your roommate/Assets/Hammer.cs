using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    public GameObject Hammerobj;
    bool HavingHammer;
    Collider2D Hammercoll;

    // Use this for initialization
    void Start () {
        HavingHammer = false;
        Hammercoll = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
