using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    static int BallCount = 0;
    public int BallNumber;
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreesPerSecond = 180;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3 - Random.value * 6 , 3 - Random.value * 6 , 3 - Random.value * 6);
        BallCount++;
        BallNumber = BallCount;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3 (XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero,axis,DegreesPerSecond * Time.deltaTime);
    }
}
