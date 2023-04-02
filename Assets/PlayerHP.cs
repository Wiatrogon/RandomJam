using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private Character player;

    public void Update()
    {
        text.text = string.Format("{0:d}/{1:d}", player.currentHP, player.MaxHP()); 
    }
}
