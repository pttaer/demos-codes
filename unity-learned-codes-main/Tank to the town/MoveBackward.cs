using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public float speed = 50;
    public float carSpeedMultiplier = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Move(1);
    }
    public virtual void Move(float multiplier)
    {
        if (multiplier > 200)
        {
            multiplier = 200;
        }
        else
        {
            multiplier = Time.deltaTime * speed * carSpeedMultiplier * Time.fixedTime;
        }
        transform.Translate(Vector3.right * multiplier);
    }
}
