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
        }


        #endregion
    
    
        public DatabaseContainerSO databaseContainer;
        
    }
}
