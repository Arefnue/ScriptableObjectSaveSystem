using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectSaveSystem.Scripts.Testers
{
    public class TesterWithSingleton : MonoBehaviour
    {
        [Header("TextPlaces")]
        public Text intExampleText;
        public Text floatExampleText;
        public Text stringExampleText;
        public Text listExampleText;
        public Text vectorExampleText;


        public void UpdateTexts()
        {
            intExampleText.text = $"IntExample: {PersistentObject.Save.databaseContainer.IntExample.ToString()}";
            floatExampleText.text = $"FloatExample: {PersistentObject.Save.databaseContainer.FloatExample.ToString(CultureInfo.InvariantCulture)}";
            stringExampleText.text = $"StringExample: {PersistentObject.Save.databaseContainer.StringContainer}";
            listExampleText.text = $"ListExample (last index): {PersistentObject.Save.databaseContainer.ListContainer[PersistentObject.Save.databaseContainer.ListContainer.Count-1].ToString()}";
            vectorExampleText.text = $"VectorExample: {PersistentObject.Save.databaseContainer.VectorContainer.ToString()}";
        }

        public void ResetDatabase()
        {
            PersistentObject.Save.databaseContainer.ResetDatabase();
        }
        
    }
}
