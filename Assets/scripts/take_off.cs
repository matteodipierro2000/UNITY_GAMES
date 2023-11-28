using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class take_off : MonoBehaviour
{
    // Update is called once per frame
    float timeCounter = -0.5f;

    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter > 0)
        {
            float x = Mathf.Cos(timeCounter);
            float y = (Mathf.Sin(timeCounter * 0.0001f) + timeCounter * 3);
            float z = -1;
            transform.position = new Vector3(x - 1.8f, y - 0.4f, z);
        }
    }
}
