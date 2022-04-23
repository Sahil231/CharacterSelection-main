using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankEnum tankType;
        public Material color;
    }

    public List<Tank> tankList;
    public TankView tankView;

    void Start()
    {
    }

    public void CreateTank(int tankNumber)
    {
        TankModel tankModel = new TankModel(tankList[tankNumber].movementSpeed, tankList[tankNumber].rotationSpeed, tankList[tankNumber].tankType, tankList[tankNumber].color);
        TankController tankController = new TankController(tankView,tankModel);
    }
}
