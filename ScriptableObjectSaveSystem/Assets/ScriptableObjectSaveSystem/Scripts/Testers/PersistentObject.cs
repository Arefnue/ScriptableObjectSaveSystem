using System;
using ScriptableObjectSaveSystem.Scripts.SaveSystem;
using UnityEngine;

namespace ScriptableObjectSaveSystem.Scripts.Testers
{
    public class PersistentObject : MonoBehaviour
    {
        #region Singleton

        public static PersistentObject Save;


        private void Awake()
        {
            if (Save == null)
            {
                Save = this;
                
            }
            else
            {
                Destroy(gameObject);
            }
            
            DontDestroyOnLoad(gameObject);
        }


        #endregion
    
    
        public DatabaseContainerSO databaseContainer;

        // In order to prevent game kill
        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus)
            {
                databaseContainer.Save();
            }
            
        }
    }
}
