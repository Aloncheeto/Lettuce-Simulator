using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LettuceScript : MonoBehaviour
{
    public string CorrectTag = "OriginalLettuce";
    public GameObject LettuceObj;
    public float i = 0;
    public float maxlettuce;
    // Start is called before the first frame update
    void Start()
    {
        maxlettuce = PlayerPrefs.GetFloat("LettuceAmount");
        Physics2D.gravity = new Vector2(0, -9.8f);
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        if (pos.y <= -8)
        {
            transform.position = new Vector3(Random.Range(-10,10), 7.2f, 0);
        }
        if (gameObject.CompareTag("OriginalLettuce"))
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                SceneManager.LoadSceneAsync("LettuceMenu");
            }
            i++;
                if (i <= maxlettuce) 
                { 
                Instantiate(LettuceObj, new Vector3(Random.Range(-8, 8), 7.2f, 0), Quaternion.AngleAxis(0,new Vector3(0,0,0)), null);
                }
                print(i);
        }
    }
}
