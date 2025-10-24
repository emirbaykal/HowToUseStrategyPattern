using UnityEngine;

namespace Skills
{
    [CreateAssetMenu(fileName = "SkillStrategy", menuName = "ScriptableObjects/Skills/Rage")]
    public class RageSkillStrategy : SkillStrategy
    {
        public GameObject ragePrefab;
        public float destroyDuration = 4;
        public override void CastSkill(Transform origin)
        {
            var rage = Instantiate(ragePrefab, origin);
            Destroy(rage, destroyDuration);
        }
    }
}