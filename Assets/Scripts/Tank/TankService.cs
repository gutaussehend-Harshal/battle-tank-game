using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Tanks.Tank;
public class TankService : MonoBehaviour
{
    public TankView tankView;
    public GameObject wrongTankView;
    // public GameObject tankView;

    // public TankScriptableObject tankConfigurations;
    public TankScriptableObjectList tankList;
    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        for (int i = 0; i < 5; i++)
        {
            CreateNewTank(i);
        }
    }

    private TankController CreateNewTank(int index)
    {
        // TankScriptableObject tankScriptableObject = tankConfigurations[2];
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        Debug.Log("Creating tank with type " + tankScriptableObject.TankName);

        TankModel model = new TankModel(tankScriptableObject);
        // TankModel model = new TankModel(TankType.None, 5, 100f);
        TankController tank = new TankController(model, tankView);
        return tank;
    }
}
