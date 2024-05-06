using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float translationSpeed = 2.0f;
    float rotationSpeed = 100.0f;
    float runSpeed = 4.0f;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        float translation = Input.GetAxis("Vertical") * translationSpeed;
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("Walking", true);
            if (translation < 0)
                anim.SetFloat("CharSpeed", -1.0f);
            else
                anim.SetFloat("CharSpeed", 1.0f);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

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
