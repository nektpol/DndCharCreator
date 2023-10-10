using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterCreatorSystem : MonoBehaviour
{
    public TMP_Dropdown raceInputField;
    public chRace yourRace;

    void Start()
    {
        List<TMP_Dropdown.OptionData> options = new();
        string[] allClasses = System.Enum.GetNames(typeof(chRace));
        foreach (string thisClass in allClasses)
        {
            options.Add(new TMP_Dropdown.OptionData(thisClass));
        }
        raceInputField.AddOptions(options);
        raceInputField.onValueChanged.AddListener(SetRace);
    }
    public void SetRace(System.Int32 index)
    {
        yourRace = (chRace)index;
    }
}
