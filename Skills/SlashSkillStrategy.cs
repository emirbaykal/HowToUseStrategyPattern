using UnityEngine;

namespace Skills
{
    [CreateAssetMenu(fileName = "SkillStrategy", menuName = "ScriptableObjects/Skills/Slash")]

    public class SlashSkillStrategy : SkillStrategy
    {
        public GameObject slashPrefab;
        public int destroyDuration;
        public override void CastSkill(Transform origin)
        {
            var slash = Instantiate(slashPrefab, origin);
            Destroy(slash, destroyDuration);
        }
    }
}