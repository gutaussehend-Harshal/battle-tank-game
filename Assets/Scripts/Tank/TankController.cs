using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outscal.BattleTank3DProject
{
    public class TankController
    {
        public TankView TankView { get; private set; }
        public TankModel TankModel { get; private set; }
        private Rigidbody rigidBody;
        public TankController(TankModel tankModel, TankView tankPrefab)
        // public TankController(TankModel tankModel, GameObject tankPrefab)
        {
            TankModel = tankModel;
            // GameObject go = GameObject.Instantiate(tankPrefab);
            // TankView = go.GetComponent<TankView>();
            TankView = GameObject.Instantiate<TankView>(tankPrefab);
            rigidBody = TankView.GetComponent<Rigidbody>();
            TankView.SetTankController(this);
            TankModel.SetTankController(this);

            Debug.Log("tank view created", TankView);
        }

    }
}