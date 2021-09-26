using UnityEngine;

namespace Gisha.PatternsPractice.CommandPattern.Core
{
    public class ClickInputReader : MonoBehaviour
    {
        public Vector3? GetClickPosition()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out var hitInfo))
                    return hitInfo.point;
            }

            return null;
        }
    }
}