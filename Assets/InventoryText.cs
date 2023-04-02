using System.Linq;
using TMPro;
using UnityEngine;

public class InventoryText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Character player;
    public void Update()
    {
        text.text = "";
        foreach (var item in player.inventory.OrderBy(item => item.Key))
        {
            if(item.Value == 0)
            {
                continue;
            }
            text.text += string.Format("{0:d}d{1:d}", item.Value, item.Key);
        }
    }
}
