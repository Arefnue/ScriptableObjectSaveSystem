using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectSaveSystem.Scripts.SaveSystem
{
    [CreateAssetMenu(menuName = "Save/Database",fileName = "Database")]
    public class DatabaseSO : ScriptableObject
    {
        [Header("Save")]
        [SerializeField] private string key; //This is your key to open your database.
        [SerializeField] private bool testMode; //Make sure to disable this whenever you try to get build or test the system. Otherwise, this must be enabled.
    
        // Write your database here. Make sure your variables are serializable. If you don't know serialization, you may look: https://docs.unity3d.com/Manual/script-Serialization.html

        [Header("Stats")]
        [SerializeField] private int intExample;
        [SerializeField] private float floatExample;
        [SerializeField] private string stringExample;
        [SerializeField] private List<int> listExample;
        [SerializeField] private Vector3 vectorExample;

    
        // To access your variables from other scripts, use properties.
        #region Properties

        public int IntExample
        {
            get => intExample;
            set => intExample = value;
        }

        public float FloatExample
        {
            get => floatExample;
            set => floatExample = value;
        }

        public string StringExample
        {
            get => stringExample;
            set => stringExample = value;
        }

        public List<int> ListExample
        {
            get => listExample;
            set => listExample = value;
        }

        public Vector3 VectorExample
        {
            get => vectorExample;
            set => vectorExample = value;
        }
    
        #endregion
    
    
        private void OnEnable()
        {
            if (testMode)
            {
                Debug.Log("Database is on test mode and SO is enabled");
            }
            else
            {
                JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(key), this);
            }
            
        }

        private void OnDisable()
        {
            Save();
        }

        public void Save()
        {
            if (testMode)
            {
                Debug.Log("Database is on test mode and SO is disabled");
            }
            else
            {
                if (key == "")
                {
                    key = name;
                }
                
                var jsonData = JsonUtility.ToJson(this, true);
                PlayerPrefs.SetString(key, jsonData);
                PlayerPrefs.Save();
                
            }
        }
    }
}
