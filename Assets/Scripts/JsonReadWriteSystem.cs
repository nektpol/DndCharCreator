using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class JsonReadWriteSystem : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void SaveToJson()
    {
        CharacterData chData = new CharacterData();
        chData.name = nameInputField.text;

        SheetData shData = new SheetData();
        shData.character = chData;
        // shData.scema_version = 3;
        // shData.type = "character";

        string json = JsonUtility.ToJson(shData,true);
        File.WriteAllText(Application.dataPath + "/CharacterSheet.json", json);
    }
}
