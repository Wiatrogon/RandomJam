using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterLevel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] public Character character;

    void Update()
    {
        if(character != null)
        {
            text.text = string.Format("Level {0:d} {1}", character.Level, character.displayName);
        }
    }
}
