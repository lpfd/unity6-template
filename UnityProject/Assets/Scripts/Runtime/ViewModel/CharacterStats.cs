using UnityEngine;

namespace Game.ViewModel
{
    [CreateAssetMenu(fileName = "CharacterStats", menuName = "Game/CharacterStats")]
    public class CharacterStats : ScriptableObject
    {
        public float _health = 100;

        public float _maxHealth = 100;
    }
}