using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    //TODO: Add properties for grid size, hex size, and hex prefab
    [field: SerializeField] public HexOrientation Orientation { get; private set; }
    [field: SerializeField] public int Width { get; private set; }
    [field: SerializeField] public int Height { get; private set; }
    [field: SerializeField] public float HexSize { get; private set; }
    //TODO: Create a grid of hexes
    //TODO: Store the individual tiles in an array
    //TODO: Methods to get, change, add, and remove tiles
    //TODO: Gizmo for drawing the grid in the editor
    private void OnDrawGizmos()
    {
        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 centrePosition = HexMetrics.Center(HexSize, x, z, Orientation) + transform.position;
                for (int s = 0; s < HexMetrics.Corners(HexSize, Orientation).Length; s++)
                {
                    Gizmos.DrawLine(
                        centrePosition + HexMetrics.Corners(HexSize, Orientation)[s % 6],
                        centrePosition + HexMetrics.Corners(HexSize, Orientation)[(s + 1) % 6]
                    );
                }
            }
        }
    }
}

public enum HexOrientation
{
    PointyTop, // Pointy-topped hexagons
    FlatTop // Flat-topped hexagons
}