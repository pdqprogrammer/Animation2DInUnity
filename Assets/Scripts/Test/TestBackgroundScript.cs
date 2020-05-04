using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBackgroundScript : MonoBehaviour
{
    public float guardSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * guardSpeed * Vector2.left);
        }
    }
}
