using System.Globalization;
using ScriptableObjectSaveSystem.Scripts.SaveSystem;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectSaveSystem.Scripts.Testers
{
    public class TesterWithDragAndUse : MonoBehaviour
    {
        [Header("DatabaseContainer")]
        [SerializeField] private DatabaseContainerSO databaseContainer;
        
        [Header("TextPlaces")]
        public Text intExampleText;
        public Text floatExampleText;
        public Text stringExampleText;
        public Text listExampleText;
        public Text vectorExampleText;


        public void UpdateTexts()
        {
            intExampleText.text = $"IntExample: {databaseContainer.IntExample.ToString()}";
            floatExampleText.text = $"FloatExample: {databaseContainer.FloatExample.ToString(CultureInfo.InvariantCulture)}";
            stringExampleText.text = $"StringExample: {databaseContainer.StringContainer}";
            listExampleText.text = $"ListExample (last index): {databaseContainer.ListContainer[databaseContainer.ListContainer.Count-1].ToString()}";
            vectorExampleText.text = $"VectorExample: {databaseContainer.VectorContainer.ToString()}";
        }

        public void ResetDatabase()
        {
            databaseContainer.ResetDatabase();
        }
    }
}
