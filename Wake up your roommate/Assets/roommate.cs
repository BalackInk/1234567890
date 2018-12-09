using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roommate : MonoBehaviour {
    public int HP = 100;
    public Text rmhp;






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HPchangeR(int a)
    {
        HP = HP + a;
        if (HP > 100)
        {
            HP = 100;
        }
        if (HP < 1)
        {
            HP = 0;
        }
        rmhp.text = HP.ToString();
    }

}
