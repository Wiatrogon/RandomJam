using TMPro;
using UnityEngine;

public class CharacterHP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private Character character;

    public void Update()
    {
        text.text = string.Format("{0:d}/{1:d}", character.currentHP, character.MaxHP()); 
    }
}
