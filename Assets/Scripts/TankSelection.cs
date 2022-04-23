using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    
    public void SelectGreenTank()
    {
        tankSpawner.CreateTank(0);
        this.gameObject.SetActive(false);
    }

    public void SelectBlueTank()
    {
        tankSpawner.CreateTank(1);
        this.gameObject.SetActive(false);
    }

    public void SelectRedTank()
    {
        tankSpawner.CreateTank(2);
        this.gameObject.SetActive(false);
    }
}
