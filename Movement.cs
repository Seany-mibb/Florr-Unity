using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        // IMPORTANT Note that the translations are opposite to the direction it should be going because this is for the
        //Background and the background moves in the opposite direction of the flower!
        // Going right
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        //Going left
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        //Going up
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        //Going down
        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

    }
}
