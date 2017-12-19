using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTChangeScene : MonoBehaviour {

    private TESTScenemanager Tman;

    // Use this for initialization
    void Start() {
        Tman = FindObjectOfType<TESTScenemanager>();
    }

    // Update is called once per frame
    void Update() {

        
}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {

            Tman.SwitchScene();
        }





    }
}