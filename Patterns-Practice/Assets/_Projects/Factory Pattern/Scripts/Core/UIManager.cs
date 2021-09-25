using Gisha.PatternsPractice.FactoryPattern.ReflectionAbilityFactory;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Core
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject abilityUIElementPrefab;
        [SerializeField] private Transform abilityUIPanel;

        private void Start()
        {
            var abilities = AbilityFactory.GetAbilities();

            foreach (var ability in abilities)
                CreateUIElement(ability.Name);
        }

        private void CreateUIElement(string abilityName)
        {
            var element = Instantiate(abilityUIElementPrefab, abilityUIPanel);
            element.GetComponent<AbilityUIElement>().SetAbilityName(abilityName);
        }
    }
}