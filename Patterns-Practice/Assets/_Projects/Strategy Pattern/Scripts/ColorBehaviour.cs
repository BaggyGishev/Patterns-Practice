using UnityEngine;

namespace Gisha.PatternsPractice.StrategyPattern
{
    public interface ColorBehaviour
    {
        public void DoColorChange(Material material);
    }

    public class UncoloredBehaviour : ColorBehaviour
    {
        public void DoColorChange(Material material)
        {
        }
    }

    public class RainbowBehaviour : ColorBehaviour
    {
        public void DoColorChange(Material material)
        {
            var r = Random.Range(0f, 1f);
            var g = Random.Range(0f, 1f);
            var b = Random.Range(0f, 1f);

            Color color = new Color(r, g, b);
            material.SetColor("_Color", color);
        }
    }
}