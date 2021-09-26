using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Gisha.PatternsPractice.FactoryPattern.ReflectionAbilityFactory
{
    public static class AbilityFactory
    {
        private static Dictionary<string, Type> _abilitiesByName;
        private static bool IsInitialized => _abilitiesByName != null;

        private static void Initialize()
        {
            if (IsInitialized)
                return;

            // Находим все классы абилок.
            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Ability)));

            // Добавляем классы абилок в словарь по string имени.
            _abilitiesByName = new Dictionary<string, Type>();
            foreach (var type in abilityTypes)
            {
                var instance = Activator.CreateInstance(type) as Ability;
                _abilitiesByName.Add(instance.Name, type);
            }
        }

        public static Ability GetAbility(string abilityName)
        {
            Initialize();

            if (_abilitiesByName.ContainsKey(abilityName))
            {
                Type type = _abilitiesByName[abilityName];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }

            return null;
        }

        public static List<Ability> GetAbilities()
        {
            Initialize();

            List<Ability> result = new List<Ability>();
            Type[] types = _abilitiesByName
                .Select(x => x.Value)
                .ToArray();

            foreach (var t in types)
                result.Add(Activator.CreateInstance(t) as Ability);

            return result;
        }
    }
}