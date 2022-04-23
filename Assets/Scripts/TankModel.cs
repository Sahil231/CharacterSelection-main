using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController _tankController;
    float movementSpeed;
    float rotationSpeed;

    public TankModel(float movementSpeed, float rotationSpeed)
    {
        this.movementSpeed=movementSpeed;
        this.rotationSpeed=rotationSpeed;
    }
    public void SetTankController(TankController _tankController)
    {
        this._tankController= _tankController;
    }
}
