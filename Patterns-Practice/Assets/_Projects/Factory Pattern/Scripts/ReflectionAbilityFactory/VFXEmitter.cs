using System;
using Gisha.PatternsPractice.FactoryPattern.Core;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.ReflectionAbilityFactory
{
    public class VFXEmitter : MonoBehaviour
    {
        private static VFXEmitter Instance { get; set; }

        [SerializeField] private VFX[] effects;

        private void Awake()
        {
            Instance = this;
        }

        public static void Emit(string vfxName)
        {
            var vfx = Array.Find(Instance.effects, x => string.Equals(x.VFXName, vfxName));

            if (vfx == null)
            {
                Debug.LogError($"VFX with name {vfxName} could not be found.");
                return;
            }

            var player = FindObjectOfType<PlayerController>();
            Instantiate(vfx.GO, player.transform.position, player.transform.rotation);
        }
    }

    [Serializable]
    public class VFX
    {
        [SerializeField] private string vfxName;
        [SerializeField] private GameObject go;

        public string VFXName => vfxName;

        public GameObject GO => go;
    }
}