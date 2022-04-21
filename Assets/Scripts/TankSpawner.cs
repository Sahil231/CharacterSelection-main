using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tank = Instantiate(tankPrefab, this.transform.position, Quaternion.identity);
        camera.transform.parent=tank.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
