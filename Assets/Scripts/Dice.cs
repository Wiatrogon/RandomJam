using UnityEngine;

public class Dice : MonoBehaviour
{
    public enum Type
    {
        d4 = 4,
        d6 = 6,
        d8 = 8,
    }

    public static int Roll(Dice.Type dice)
    {
        return Random.Range(1, (int) dice + 1);
    }
}
