using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Tanks.Tank;
namespace Outscal.BattleTank3DProject
{
    public class TankService : MonoSingletonGeneric<TankService>
    {
        // public TankView tankView;
        // public GameObject wrongTankView;
        // public GameObject tankView;

        // public TankScriptableObject tankConfigurations;
        public TankScriptableObjectList tankList;
        private void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            // for (int i = 0; i < 3; i++)
            // {
                CreateNewTank();
            // }
        }

        private TankController CreateNewTank()
        {
            int randomNo = Random.Range(0, tankList.tanks.Length);
            // TankScriptableObject tankScriptableObject = tankConfigurations[2];
            TankScriptableObject tankScriptableObject = tankList.tanks[randomNo];
            Debug.Log("Creating tank with type " + tankScriptableObject.TankName);
            TankView tankView = tankScriptableObject.TankView;
            TankModel model = new TankModel(tankScriptableObject);
            // TankModel model = new TankModel(TankType.None, 5, 100f);
            TankController tank = new TankController(model, tankView);
            return tank;
        }
    }
}