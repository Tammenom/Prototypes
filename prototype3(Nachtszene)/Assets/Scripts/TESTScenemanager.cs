using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTScenemanager : MonoBehaviour {

    public GameObject[] foregroundScene1;
    public GameObject[] foregroundScene2;


    private Vector3 targetPos;
    private Vector3 newVector;
    public float picmax;
    public float picmin;

    public float moveSpeed;
    public float groundMoveSpeed;
    private float xCorrection;


    public int activeScene1;
    public int activeScene2;

    public bool nextScene1;
    public bool nextScene2;

    // Use this for initialization
    void Start () {

        xCorrection = groundMoveSpeed;

        for (int a = 0; a < foregroundScene1.Length; a++)
        {
            foregroundScene1[a].SetActive(false);
        }

        for (int a = 0; a < foregroundScene2.Length; a++)
        {
            foregroundScene2[a].SetActive(false);
        }

        activeScene1 = 0;
        activeScene2 = 0;
        nextScene1 = false;
        nextScene2 = false;



    }

// Update is called once per frame
void Update () {

        foregroundScene1[activeScene1].SetActive(true);
        foregroundScene2[activeScene2].SetActive(true);

        targetPos = new Vector3(foregroundScene1[activeScene1].transform.position.x + xCorrection, foregroundScene1[activeScene1].transform.position.y, foregroundScene1[activeScene1].transform.position.z);

        foregroundScene1[activeScene1].transform.position = Vector3.Lerp(foregroundScene1[activeScene1].transform.position, targetPos, moveSpeed * Time.deltaTime);


        targetPos = new Vector3(foregroundScene2[activeScene2].transform.position.x + xCorrection, foregroundScene2[activeScene2].transform.position.y, foregroundScene2[activeScene2].transform.position.z);

        foregroundScene2[activeScene2].transform.position = Vector3.Lerp(foregroundScene2[activeScene2].transform.position, targetPos, moveSpeed * Time.deltaTime);
        

        if (nextScene1 == true && activeScene1 < foregroundScene1.Length)
        {
            if (foregroundScene1[activeScene1].transform.position.x >= picmax)
            {
                foregroundScene1[activeScene1].SetActive(false);
                activeScene1++;
                nextScene1 = false;
            }
        }

        if (nextScene2 == true && activeScene2 < foregroundScene2.Length)
        {
            if (foregroundScene2[activeScene2].transform.position.x >= picmax)
            {
                foregroundScene2[activeScene2].SetActive(false);
                activeScene2++;
                nextScene2 = false;
            }
        }


        if (foregroundScene1[activeScene1].transform.position.x >= 15)
        {
            newVector = new Vector3(-15, foregroundScene1[activeScene1].transform.position.y, foregroundScene1[activeScene1].transform.position.z);

            foregroundScene1[activeScene1].transform.position = newVector;

            xCorrection = groundMoveSpeed;


        }

        if (foregroundScene2[activeScene2].transform.position.x >= picmax)
        {
            newVector = new Vector3(-15, foregroundScene2[activeScene2].transform.position.y, foregroundScene2[activeScene2].transform.position.z);

            foregroundScene2[activeScene2].transform.position = newVector;

            xCorrection = groundMoveSpeed;


        }





    }


    public void SwitchScene()
    {
        nextScene1 = true;
        nextScene2 = true;

    }


}
