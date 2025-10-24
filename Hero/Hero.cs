using System;
using Skills;
using UnityEngine;

namespace Hero
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] private SkillStrategy[] skills;
        private void OnEnable()
        {
            HeadsUpDisplay.OnButtonPressed += CastSkill;
        }

        private void OnDisable()
        {
            HeadsUpDisplay.OnButtonPressed -= CastSkill;
        }

        void CastSkill(int index)
        {
            skills[index].CastSkill(transform);
        }
    }
}