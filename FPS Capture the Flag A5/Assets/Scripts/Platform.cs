using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float trackSpeed;
    public float trackDistance;
    public float rotSpeed;
    private Vector3 startPos;
    private bool isTracking;
    private bool isRotating;

    // Start is called before the first frame update
    void Start()
    {
      startPos = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = (isTracking == true ? new Vector3(0, 0, trackDistance / 2) : new Vector3(0, 0, -trackDistance /2));
        transform.position = Vector3.MoveTowards(transform.position, startPos + offset, trackSpeed * Time.deltaTime);

        if(transform.position == startPos + offset)
            isTracking = !isTracking;
    }
}
