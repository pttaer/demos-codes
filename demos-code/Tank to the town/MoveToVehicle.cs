using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToVehicle : MoveBackward //INHERIT
{
    private MoveBackward MoveBackward;
    private PlayerController PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        MoveBackward = GetComponent<MoveBackward>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Move(1);
    }
    //POLYMORPHISM
    public override void Move(float speedMultiplier)
    {
        if (speedMultiplier > 200)
        {
            speedMultiplier = 200;
        }
        else
        {
            speedMultiplier = Time.deltaTime * MoveBackward.speed * MoveBackward.carSpeedMultiplier * Time.fixedTime;
            transform.Translate(Vector3.forward * speedMultiplier);
        }
    }
}
