using UnityEngine;

public class CellGenerator 
{
    public void CreateCells(int width, int height, GameObject prefab)
    {
        for (int i = 0; i < width*height; i++)
        {
            GameObject.Instantiate(prefab, new Vector3(i, 0, i), Quaternion.identity);
        }
    }
}