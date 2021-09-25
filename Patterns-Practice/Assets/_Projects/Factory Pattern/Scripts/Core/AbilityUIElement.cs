using Gisha.PatternsPractice.FactoryPattern.ReflectionAbilityFactory;
using TMPro;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Core
{
    public class AbilityUIElement : MonoBehaviour
    {
        [SerializeField] private TMP_Text tmpText;
        
        private string _abilityName;

        public void SetAbilityName(string abilityName)
        {
            _abilityName = abilityName;
            tmpText.text = _abilityName;
        }

        public void OnClick()
        {
            if (string.IsNullOrEmpty(_abilityName))
            {
                Debug.LogError("Empty ability name");
                return;
            }

            AbilityFactory.GetAbility(_abilityName).Process();
        }
    }
}