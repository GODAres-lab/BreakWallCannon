using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed;
    public float xDegrees, yDegrees;

    public Transform cannonBody;

    // Update is called once per frame
    void Update()
    {
        CannonMovement();
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticaInput = Input.GetAxis("Vertical");
        yDegrees += horizontalInput * rotationSpeed * Time.deltaTime;
        xDegrees += verticaInput * rotationSpeed * Time.deltaTime;

        yDegrees =  Mathf.Clamp(yDegrees, -45, 45);
        xDegrees = Mathf.Clamp(xDegrees, -7, 48);

        cannonBody.localEulerAngles = new Vector3(0, xDegrees, yDegrees);
    }
}
