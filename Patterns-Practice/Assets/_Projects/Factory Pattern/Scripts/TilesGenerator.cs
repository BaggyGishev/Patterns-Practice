using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern
{
    public class TilesGenerator : MonoBehaviour
    {
        [SerializeField] private int xSize = 3;
        [SerializeField] private int zSize = 3;
        [Space] [SerializeField] private GameObject tilePrefab;
        [SerializeField] private Transform tilesParent;

        private List<GameObject> _tiles = new List<GameObject>();

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
                _tiles.Add(SpawnTile(x, z));
        }

        private void RemoveTiles()
        {
            foreach (var tile in _tiles) Destroy(tile);
            _tiles = new List<GameObject>();
        }

        private GameObject SpawnTile(int x, int z)
        {
            var position = new Vector3(x * 10.1f, 0f, z * 10.1f);
            return Instantiate(tilePrefab, position, Quaternion.identity, tilesParent);
        }
    }
}