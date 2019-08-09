using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {



    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        print("You DIEDED!");
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
