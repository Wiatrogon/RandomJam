using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private Player player;

    public void Start()
    {
        text.text = string.Format("{0}/{1}", player.currentHP.ToString(), player.MaxHP().ToString() ); 
    }
}
