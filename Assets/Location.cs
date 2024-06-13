using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public Transform fullStrap;
    public Transform cameraTransform;

    public Transform cube1; // X = -0.2 Z = 0
    public Transform cube2; // X = -0.15 Z = 0.15
    public Transform cube3; // X = 0 Z = 0.2
    public Transform cube4; // X = 0.15 Z = 0.15
    public Transform cube5; // X = 0.2 Z = 0


    public float yOffset = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = fullStrap.position;
        newPosition.y = cameraTransform.position.y - yOffset;
        newPosition.x = cameraTransform.position.x;
        newPosition.z = cameraTransform.position.z;
        fullStrap.position = newPosition;

        // Cubes are placed in a circle around strap
        cube1.position = new Vector3(fullStrap.position.x - 0.2f, fullStrap.position.y, fullStrap.position.z);
        cube2.position = new Vector3(fullStrap.position.x - 0.15f, fullStrap.position.y, fullStrap.position.z + 0.15f);
        cube3.position = new Vector3(fullStrap.position.x, fullStrap.position.y, fullStrap.position.z + 0.2f);
        cube4.position = new Vector3(fullStrap.position.x + 0.15f, fullStrap.position.y, fullStrap.position.z + 0.15f);
        cube5.position = new Vector3(fullStrap.position.x + 0.2f, fullStrap.position.y, fullStrap.position.z);

    }
}
