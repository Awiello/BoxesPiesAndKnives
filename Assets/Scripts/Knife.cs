using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    public GameObject knifeDestructionEffect;
    private Vector3 knifePos;
    private GameObject knifeObject;




    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        //Instantiate(knifeDestructionEffect, knifePos, Quaternion.identity);
    }

    void Start(){
    }


    // Update is called once per frame
    void Update () {
	}
}
