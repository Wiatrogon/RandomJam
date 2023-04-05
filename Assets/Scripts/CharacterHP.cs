using TMPro;
using UnityEngine;

public class CharacterHP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    public Character character;

    public void Update()
    {
        if (character != null)
        {
            text.text = string.Format("{0:d}/{1:d}", character.currentHP, character.MaxHP); 
        }
    }
}
