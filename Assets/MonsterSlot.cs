using UnityEngine;

public class MonsterSlot : MonoBehaviour
{
    Monster monster;
    [SerializeField] CharacterHP monsterHP;

    void Update()
    {
        if (IsEmpty())
        {
            SpawnMonster();
        }
    }

    public bool IsEmpty()
    {
        return monster == null || monster.currentHP <= 0;
    }

    public void SpawnMonster()
    {
        monster = this.gameObject.AddComponent<Monster>();
        monsterHP.character = monster;
    }

    public void Combat()
    {
        monster.Combat();
    }
}
