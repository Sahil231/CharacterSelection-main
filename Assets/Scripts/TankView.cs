using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject cam;
    private TankController _tankController;

    float movement;
    float rotation;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.transform.SetParent(this.transform);
    }
    void Update()
    {
        movement=Input.GetAxis("Vertical");
        rotation=Input.GetAxis("Horizontal");

        if(movement!=0)
            _tankController.Move(movement,30);
        if(rotation!=0)
            _tankController.Rotate(rotation,100);

    }
    public void SetTankController(TankController _tankController)
    {
        this._tankController= _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
