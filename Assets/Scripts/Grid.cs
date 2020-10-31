using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    /*Esto es caca, claramente
    //Creación de valores
    public int[] cell;
    public int cellSize;

    public bool[] value;

    //Asignación de grid
    public GameObject gridInterior;
    public GameObject[] gridCell;

    // Start is called before the first frame update
    void Start()
    {
        //Tamaño de la grid
        cellSize = 25;
        cell = new int[cellSize];
        value = new bool[cellSize];
        gridCell = new GameObject[cellSize];

        //Valor para cada celda de forma aleatoria
        for(int i = 0; i < cellSize; i++)
        {
            cell[i] = UnityEngine.Random.Range(1, 25); //Falta hacer que no se repitan lo valores
            gridCell[i] = gridInterior.transform.GetChild(cell[i]).gameObject;

            value[i] = UnityEngine.Random.value < 0.6f;
            Debug.Log(value[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public int isTrueChance = 60;

    public CellBehaviour[] cells;

    public RowBehaviour[] rows;

    public void Initialize()
    {
        //Inicializar celdas
        cells = GetComponentsInChildren<CellBehaviour>();

        foreach(CellBehaviour cell in cells)
        {
            int randomValue;
            randomValue = Random.Range(0, 100);

            if(randomValue <= isTrueChance) cell.Initialize(true);
            else cell.Initialize(false);
        }

        ResetCells();


        //Inicializar columnas
        rows = GetComponentsInChildren<RowBehaviour>();

        foreach(RowBehaviour row in rows)
        {
            row.Initialize();
        }
    }

    public void ResetCells()
    {
        //Reiniciar celdas
        foreach(CellBehaviour cell in cells)
        {
            cell.ResetCell();
        }
    }
}
