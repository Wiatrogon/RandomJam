using UnityEngine;

public class Dice : MonoBehaviour
{
    public int maxRoll = 6;

    public int Roll()
    {
        return Random.Range(1, maxRoll + 1);
    }

}
