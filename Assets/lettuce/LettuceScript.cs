using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LettuceScript : MonoBehaviour
{
    public string CorrectTag = "OriginalLettuce";
    public GameObject LettuceObj;
    public GameObject LettuceObjnophys;
    public Rigidbody2D lttrgb2;
    public float i = 0;
    public float maxlettuce;
    private bool dragging = false;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        lttrgb2 = GetComponent<Rigidbody2D>();
        maxlettuce = PlayerPrefs.GetFloat("LettuceAmount");
        Physics2D.gravity = new Vector2(0, -9.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            Vector2 mousePosition = Input.mousePosition; // This line grabs the raw mouse position
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); // This line converts the raw position into a position in the world space
            lttrgb2.MovePosition(mousePosition);
        }
        var pos = transform.position;
        if (pos.y <= -8)
        {
            transform.position = new Vector3(Random.Range(-10, 10), Random.Range(7,8), 0);
            InitiateCoolDown();
        }
        if (pos.y >= 8.5)
        {
            transform.position = new Vector3(Random.Range(-10, 10), Random.Range(7, 8), 0);
            InitiateCoolDown();
        }
        if (gameObject.CompareTag("OriginalLettuce"))
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                SceneManager.LoadSceneAsync("LettuceMenu");
            }
            i++;
            if (true != false)
            {
                if (i <= maxlettuce)
                {
                    Instantiate(LettuceObj, new Vector3(Random.Range(-8, 8), Random.Range(7, 8), 0), Quaternion.AngleAxis(0, new Vector3(0, 0, 0)), null);
                }
            }
            
        }
        if (pos.x <= -11)
        {
            transform.position = new Vector3(Random.Range(-10, 10), 7.2f, 0);
            InitiateCoolDown();

        }
        if (pos.x >= 11)
        {
            transform.position = new Vector3(Random.Range(-10, 10), 7.2f, 0);
            InitiateCoolDown();
        }
    }
    private void OnMouseDown()
    {
        // Record the difference between the objects centre, and the clicked point on the camera plane.
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }
    private void OnMouseUp()
    {
        // Stop dragging.
        dragging = false;
    }
    private void InitiateCoolDown()
    {
        dragging = false;
    }
}

