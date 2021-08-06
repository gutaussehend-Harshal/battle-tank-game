using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    // public TankController(TankModel tankModel, GameObject tankPrefab)
    {
        TankModel = tankModel;

        // GameObject go = GameObject.Instantiate(tankPrefab);
        // TankView = go.GetComponent<TankView>();

        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        Debug.Log("tank view created", TankView);
    }

    public TankModel TankModel { get; private set; }
    public TankView TankView { get; private set; }
}
