using UnityEngine;

public class MonsterSlot : MonoBehaviour
{
    Monster monster;
    [SerializeField] CharacterHP monsterHP;
    [SerializeField] MonsterSpawner spawner;
    [SerializeField] CharacterLevel monsterLevel;

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
        monster = spawner.CreateMonster(this);
        monsterHP.character = monster;
        monsterLevel.character = monster;
    }

    public void Combat()
    {
        monster.Combat();
    }
}
