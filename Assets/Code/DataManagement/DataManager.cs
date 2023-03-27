using System.Threading.Tasks;
using Code.Base;
using Code.Config;
using UnityEngine;
using UnityEngine.Events;

namespace Code.DataManagement
{
    public class DataManager : MonoBehaviour, IDataManager
    {
        private GameConfig _gameConfig;

        public async void LoadData(UnityAction finished)
        {
            _gameConfig = new GameConfig();
            Task<PlayGrid> grid = JsonLoader.LoadAsync<PlayGrid>(FormatPath(ConfigsPath.GRID_CONFIG_NAME));
            Task<ErrorCodes> errorCodes = JsonLoader.LoadAsync<ErrorCodes>(FormatPath(ConfigsPath.ERRORS_CONFIG_NAME));
            
            await Task.WhenAll(grid, errorCodes);
            _gameConfig.Grid = grid.Result;
            _gameConfig.ErrorCodes = errorCodes.Result;
            
            finished?.Invoke();
        }

        private string FormatPath(string configName)
        {
            return ConfigsPath.JSON_FILES_PATH + configName + ConfigsPath.JSON_FILE_EXT;
        }
    }
}