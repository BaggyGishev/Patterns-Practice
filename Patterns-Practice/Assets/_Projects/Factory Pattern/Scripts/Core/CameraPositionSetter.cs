using Gisha.PatternsPractice.FactoryPattern.Tiles;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Core
{
    public class CameraPositionSetter : MonoBehaviour
    {
        [SerializeField] private Vector3 positionOffset;
        [SerializeField] private Vector3 rotationOffset;

        private void OnEnable()
        {
            TilesGenerator.TilesSpawned += OnTilesSpawned;
        }

        private void OnDisable()
        {
            TilesGenerator.TilesSpawned -= OnTilesSpawned;
        }

        private void OnTilesSpawned()
        {
            var xPos = TilesManager.XSize / 2f * 10.1f;
            var zPos = TilesManager.ZSize / 2f * 10.1f;
            var pos = new Vector3(xPos, 0f, zPos) + positionOffset;

            transform.position = pos;
            transform.rotation = Quaternion.Euler(rotationOffset);
        }
    }
}