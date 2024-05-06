using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    float runSpeed = 4.0f;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the Left Shift key is pressed
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        // If running, trigger the "Running" animation
        if (isRunning)
        {
            anim.SetBool("Running", true);
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}
