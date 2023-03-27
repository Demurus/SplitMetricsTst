using Code.DataManagement;
using UnityEngine;
using Zenject;

namespace Code.Base
{
    public class GameController : MonoInstaller
    {
        [SerializeField] private DataManager _dataManager;

        public override void InstallBindings()
        {
            Container.Bind<IDataManager>().FromInstance(_dataManager);
        }
        
        public override void Start()
        {
            base.Start();
            IDataManager dataManager = Container.Resolve<IDataManager>();
            dataManager.LoadData(Continue);
            void Continue()
            {
               Debug.Log("Config data successfully loaded");
            }
        }
    }
}