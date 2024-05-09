using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject LButton;
    public GameObject RButton;
    // GameObject arrowPrefab;


    // Start is called before the first frame update
    void Start()
    {
        // this.arrowPrefab = GameObject.Find("arrowPrefab");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
        LButton.GetComponent<AudioSource>().Play();
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
        RButton.GetComponent<AudioSource>().Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }


        // Vector2 p1 = transform.position;
        // Vector2 p2 = this.arrowPrefab.transform.position;
        // Vector2 dir = p1 - p2;
        // float d = dir.magnitude;
        // float r1 = 0.5f;
        // float r2 = 1.0f;

        // if (d < r1 + r2)
        // {
        //     GetComponent<AudioSource>().Play();
        // }

        if (Time.timeScale <= 0f)
        {
            this.enabled = false;
        }
    }
}
