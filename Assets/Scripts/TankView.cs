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

    public MeshRenderer[] tankPartsColor;

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
            _tankController.Move(movement,_tankController.GetMovementSpeed());
        if(rotation!=0)
            _tankController.Rotate(rotation,_tankController.GetRotationSpeed());

        ColorTheTank(_tankController.GetTankColor());

    }
    public void SetTankController(TankController _tankController)
    {
        this._tankController= _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ColorTheTank(Material color)
    {
        for(int i=0; i<tankPartsColor.Length; i++)
        {
            tankPartsColor[i].material= color;
        }
    }
}
