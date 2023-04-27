using UnityEngine;
using System;
using System.Collections;

public class Walk : MonoBehaviour
{

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        Console.WriteLine("Start");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    async void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Console.WriteLine("UpArrow");
            // Application.Exit();
            transform.position += transform.forward * 0.005f;
            animator.SetBool("is_walk", true);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 0.005f;
            animator.SetBool("is_walk", true);
        }
        else
        {
            animator.SetBool("is_walk", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.2f, 0);
        }
    }

}