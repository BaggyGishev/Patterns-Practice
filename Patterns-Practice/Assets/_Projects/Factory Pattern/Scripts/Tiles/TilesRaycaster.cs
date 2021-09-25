using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Tiles
{
    public class TilesRaycaster : MonoBehaviour
    {
        [SerializeField] private LayerMask whatIsTile;

        public Transform SelectedTile { get; private set; }


        private void Update()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, whatIsTile))
            {
                SelectedTile = hitInfo.transform;
                Debug.Log(SelectedTile.transform.position);
            }
        }
    }
}