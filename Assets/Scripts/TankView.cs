using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    public void SetTankController(TankController _tankController)
    {
        this._tankController= _tankController;
    }
}
