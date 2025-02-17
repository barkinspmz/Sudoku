using UnityEngine;

public class CellGenerator 
{
    public void CreateCells(int width, int height, GameObject prefab, Transform parentObject
        , Vector2 startPos)
    {
        for (int i = 0; i < height; i++)
        {
            float decreaseWidth = startPos.x;
            for (int j = 0; j < width; j++)
            {
                var cell = GameObject.Instantiate(prefab, new Vector2(decreaseWidth, startPos.y), Quaternion.identity);
                cell.transform.parent = parentObject;
                cell.transform.localPosition = new Vector2(decreaseWidth, startPos.y);
                cell.transform.localScale = new Vector2(0.92f, 0.92f);
                decreaseWidth += 100;
            }

            startPos = new Vector2(startPos.x, startPos.y - 100);
        }
    }
}