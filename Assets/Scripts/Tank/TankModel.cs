using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankScriptableObject tankScriptableObject;
    public TankModel(TankScriptableObject tankScriptableObject)
    {
        this.tankScriptableObject = tankScriptableObject;
        TankType = tankScriptableObject.TankType;
        Speed = (int)tankScriptableObject.Speed;
        Health = tankScriptableObject.Health;
    }
    public TankModel(TankType tankType, int speed, float health)
    {
        TankType = tankType;
        Speed = speed;
        Health = health;
    }

    public int Speed { get; private set; }
    public float Health { get; private set; }
    public TankType TankType { get; private set; }
    public int SpeedLive { get { return (int)tankScriptableObject.Speed; }}
}
