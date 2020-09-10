using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectSaveSystem.Scripts.SaveSystem
{
    [CreateAssetMenu(menuName = "Save/DatabaseContainer",fileName = "DatabaseContainer")]
    public class DatabaseContainerSO : ScriptableObject
    {
        [Header("Database")] 
        [SerializeField] private DatabaseSO saveProfile;

    
        [Header("Stats")]
    
        // Write your default values of database here.

        [SerializeField] private int intContainer;
        [SerializeField] private float floatContainer;
        [SerializeField] private string stringContainer;
        [SerializeField] private List<int> listContainer;
        [SerializeField] private Vector3 vectorContainer;

    
        // To access your variables from other scripts, use properties.
        #region Properties

    
        public int IntExample //Simple version to access database
        {
            get => saveProfile.IntExample;
            set => saveProfile.IntExample = value;
        }

        public float FloatExample //Secured version to access database
        {
            get => saveProfile != null ? saveProfile.FloatExample : floatContainer;
            set
            {
                if (saveProfile != null)
                {
                    saveProfile.FloatExample = value;
                }
                else
                {
                    floatContainer = value;
                }
            }
        }

        public string StringContainer
        {
            get => saveProfile.StringExample;
            set => saveProfile.StringExample = value;
        }

        public List<int> ListContainer
        {
            get => saveProfile.ListExample;
            set => saveProfile.ListExample = value;
        }

        public Vector3 VectorContainer
        {
            get => saveProfile.VectorExample;
            set => saveProfile.VectorExample = value;
        }

        #endregion
    
        public void ResetDatabase()
        {
            saveProfile.IntExample = intContainer;
            saveProfile.FloatExample = floatContainer;
            saveProfile.StringExample = stringContainer;
            saveProfile.ListExample = listContainer;
            saveProfile.VectorExample = vectorContainer;

        }

        public void Save()
        {
            saveProfile.Save();
        }
    
    
    }
}
