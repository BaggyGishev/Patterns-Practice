using System;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Tiles
{
    public class TilesGenerator : MonoBehaviour
    {
        [SerializeField] private int xSize = 3;
        [SerializeField] private int zSize = 3;
        
        [Space] [SerializeField] private GameObject tilePrefab;
        [SerializeField] private Transform tilesParent;

        public static Action TilesSpawned;

        private void Awake()
        {
            TilesManager.CreateTilesList(xSize, zSize);
        }

        private void OnValidate()
        {
            xSize = Mathf.Max(0, xSize);
            zSize = Mathf.Max(0, zSize);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SpawnTiles();
        }

        [ContextMenu("Spawn Tiles")]
        public void SpawnTiles()
        {
            if (!Application.isPlaying)
            {
                Debug.LogError("Enter playmode to spawn tiles!");
                return;
            }

            Debug.Log("Removing tiles.");
            RemoveTiles();

            Debug.Log("Spawning tiles.");
            for (int z = 0; z < zSize; z++)
            for (int x = 0; x < xSize; x++)
                TilesManager.Tiles.Add(SpawnTile(x, z));
            
            TilesSpawned?.Invoke();
        }

        private void RemoveTiles()
        {
            foreach (var tile in TilesManager.Tiles)
                Destroy(tile);
            TilesManager.CreateTilesList(xSize, zSize);
        }

        private GameObject SpawnTile(int x, int z)
        {
            var position = new Vector3(x * 10.1f, 0f, z * 10.1f);
            return Instantiate(tilePrefab, position, Quaternion.identity, tilesParent);
        }
    }
}