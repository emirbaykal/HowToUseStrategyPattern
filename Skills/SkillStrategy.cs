using UnityEngine;

namespace Skills
{
    public abstract class SkillStrategy : ScriptableObject
    {
        public abstract void CastSkill(Transform origin);
    }
}