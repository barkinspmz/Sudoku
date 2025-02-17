using System;
using UnityEngine;

namespace Managers
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField] private GameObject _cellPrefab;
        private CellGenerator _cellGenerator;
        [SerializeField] private Vector2 startPosition;
        [SerializeField] private Transform parentTransform;
        private void Start()
        {
            _cellGenerator = new CellGenerator();
            _cellGenerator.CreateCells(9, 9, _cellPrefab, parentTransform, startPosition);
        }
    }
}