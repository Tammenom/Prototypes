using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;

    
    private Vector3 targetPos;
    public float moveSpeed;
    public float xCorrection;
    public float yCorrection;
    private static bool cameraExists;
    public float camzoom;
    private double jkl;
    double dfg;
    



    // Use this for initialization
    void Start () {
        camzoom = 2;
        jkl = 0.01;
        dfg = 0.01;
        

        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }


    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Camera>().orthographicSize = camzoom;
        

        if (Input.GetKey(KeyCode.Q) && camzoom <2.7)
        {
            camzoom = camzoom + (float)jkl;
            yCorrection = yCorrection + (float)dfg;


        }

        if (Input.GetKey(KeyCode.E) && camzoom >= 1.5)
        {
            camzoom = camzoom - (float)jkl;
           yCorrection = yCorrection - (float)dfg;


        }




        targetPos = new Vector3(followTarget.transform.position.x + xCorrection, followTarget.transform.position.y + yCorrection, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);

    }

    public void SetCamMin()
    {
       camzoom = 16 / 10;
        yCorrection = 15 / 100;

    }

    public void SetCamMax()
    {
        camzoom = 27 / 10;
        yCorrection = 13 / 10;

    }
}
