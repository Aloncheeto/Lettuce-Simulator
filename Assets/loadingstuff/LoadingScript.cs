using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadingScript : MonoBehaviour
{
    public GameObject sqr1;
    public GameObject sqr2;
    public GameObject sqr3;
    public GameObject sqr4;
    public GameObject sqr5;
    public GameObject sqr6;
    public GameObject sqr7;
    public GameObject sqr8;
    public float timer;
    public int squareindex;
    public float RandLoadTime;
    public float loadtimer;
    // Start is called before the first frame update
    void Start()
    {
        sqr1 = GameObject.Find("sqr1");
        sqr2 = GameObject.Find("sqr2");
        sqr3 = GameObject.Find("sqr3");
        sqr4 = GameObject.Find("sqr4");
        sqr5 = GameObject.Find("sqr5");
        sqr6 = GameObject.Find("sqr6");
        sqr7 = GameObject.Find("sqr7");
        sqr8 = GameObject.Find("sqr8");
        RandLoadTime = UnityEngine.Random.Range(7,12);
        sqr1.SetActive(false);
        sqr2.SetActive(false);
        sqr3.SetActive(false);
        sqr4.SetActive(false);
        sqr5.SetActive(false);
        sqr6.SetActive(false);
        sqr7.SetActive(false);
        sqr8.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        loadtimer += Time.deltaTime;
        squareindex = Mathf.FloorToInt(timer);
        print(squareindex);
        if (squareindex == 1) 
        {
            sqr1.SetActive(true);
        }
        if (squareindex == 2)
        {
            sqr2.SetActive(true);
        }

        if (squareindex == 3)
        {
            sqr3.SetActive(true);
        }
        if (squareindex == 4)
        {
            sqr4.SetActive(true);
        }
        if (squareindex == 5)
        {
            sqr5.SetActive(true);
        }
        if (squareindex == 6) 
            {
            sqr6.SetActive(true); 
            }
        if (squareindex == 7)
        {
            sqr7.SetActive(true);
        }
        if (squareindex == 8)
        {
            sqr8.SetActive(true);
        }
        if (squareindex >= 9) 
                {
            timer = 0;
                }
        if (loadtimer >= RandLoadTime)
        {
            SceneManager.LoadScene(1);
        }

    }
}
