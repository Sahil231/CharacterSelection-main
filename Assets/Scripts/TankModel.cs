using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController _tankController;
    float movementSpeed;
    float rotationSpeed;
    TankEnum tankType;
    Material color;

    public TankModel(float movementSpeed, float rotationSpeed, TankEnum tankType, Material color)
    {
        this.movementSpeed=movementSpeed;
        this.rotationSpeed=rotationSpeed;
        this.tankType=tankType;
        this.color=color;
    }
    public void SetTankController(TankController _tankController)
    {
        this._tankController= _tankController;
    }

    public Material GetColor()
    {
        return color;
    }

    public float GetMovementSpeed()
    {
        return movementSpeed;
    }

    public float GetRotationSpeed()
    {
        return rotationSpeed;
    }
}
