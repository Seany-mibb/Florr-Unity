using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = float.MaxValue;
    [SerializeField] private Transform rotateAround;
    // Update is called once per frame
    Vector3 basePosition;
    Vector3 updatedPosition;

    void Start()
    {
        updatedPosition = transform.position;
    }

    void Update()
    {
        updatedPosition = transform.position;
        this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * Time.deltaTime);
        checkSpace();
    }

    void checkSpace()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position = updatedPosition * 2;
            this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = updatedPosition / 2;
            this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
