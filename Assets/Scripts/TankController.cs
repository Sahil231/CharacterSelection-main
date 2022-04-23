using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankView _tankView;
    private TankModel _tankModel;
    Rigidbody rb;
    
    public TankController(TankView _tankView, TankModel _tankModel)
    {
        this._tankView= GameObject.Instantiate<TankView>(_tankView);
        this._tankModel= _tankModel;

        rb=this._tankView.GetRigidbody();

        this._tankView.SetTankController(this);
        this._tankModel.SetTankController(this);

        _tankView.ColorTheTank(_tankModel.GetColor());
        
    }

    public void Move(float movement , float movementSpeed)
    {
        rb.velocity = _tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate , float rotateSpeed)
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler( new Vector3(0, rotateSpeed * rotate * Time.deltaTime, 0)));
    }

    public float GetMovementSpeed()
    {
        return _tankModel.GetMovementSpeed();
    }

    public float GetRotationSpeed()
    {
        return _tankModel.GetRotationSpeed();
    }

    public Material GetTankColor()
    {
        return _tankModel.GetColor();
    }

}
