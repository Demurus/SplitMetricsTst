using UnityEngine.Events;

namespace Code.DataManagement
{
    public interface IDataManager
    {
        void LoadData(UnityAction finished);
    }
}