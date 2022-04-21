using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankView _tankView;
    private TankModel _tankModel;
    
    public TankController(TankView _tankView, TankModel _tankModel)
    {
        this._tankView= _tankView;
        this._tankModel= _tankModel;

        _tankView.SetTankController(this);
        _tankModel.SetTankController(this);
        
        GameObject.Instantiate(_tankView.gameObject);
    }

}
