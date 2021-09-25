using System.Collections.Generic;
using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.Tiles
{
    public static class TilesManager
    {
        public static List<GameObject> Tiles { private set; get; }

        public static int XSize { get; private set; }
        public static int ZSize { get; private set; }

        public static void CreateTilesList(int xSize, int zSize)
        {
            Tiles = new List<GameObject>();
            XSize = xSize;
            ZSize = zSize;
        }
    }
}