using UnityEngine;

namespace Skills
{
    [CreateAssetMenu(fileName = "SkillStrategy", menuName = "ScriptableObjects/Skills/Shield")]
    public class ShieldSkillStrategy : SkillStrategy
    {
        public GameObject shieldPrefab;
        public float destroyDuration = 4;
        
        public override void CastSkill(Transform origin)
        {
            var shield = Instantiate(shieldPrefab, origin);
            Destroy(shield, destroyDuration);
        }
    }
}