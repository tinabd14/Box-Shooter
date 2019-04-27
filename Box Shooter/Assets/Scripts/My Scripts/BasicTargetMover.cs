using System.Collections;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{

    public bool doSpin = true;
    public bool moveUpAndDown = true;

    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    void Update()
    {
        Rotate();
        MoveUpAndDown();
    }

 
    private void Rotate()
    {
        if(doSpin)
        {
            //rotate around the up axis of the game object
            spinSpeed = 180f;
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        else
        {
            spinSpeed = 0f;
        }
    }


    private void MoveUpAndDown()
    {
        if(moveUpAndDown)
        {
            //move up and down over time
            motionMagnitude = 0.1f;
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
        else
        {
            motionMagnitude = 0f;
        }
      
    }
}
