using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_Inside : MonoBehaviour{

    
    public GameObject inBox;
    public GameObject cabine;
    public GameObject outerCabine;
    public string hello;
    public Camera incam;
    public CameraController dd;

    // Use this for initialization
    void Start()
    {
        inBox.SetActive(false);
        cabine.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        dd = FindObjectOfType<CameraController>();


    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inBox.SetActive(true);
            cabine.SetActive(true);
            dd.SetCamMin();
            outerCabine.SetActive(false);





        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inBox.SetActive(false);
            cabine.SetActive(false);
            dd.SetCamMax();
            outerCabine.SetActive(true);

        }

    }
}
