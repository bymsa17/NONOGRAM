using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowBehaviour : MonoBehaviour
{
    public CellBehaviour[] rowCells;

    public Text[] ammountTexts;

    public void Initialize()
    {
        int rowValue = 0;
        int textID = 0;

        //lee las casillas del revés para escribir en el texto la cantidad de casillas True que hay en la columna
        for(int i = rowCells.Length - 1; i > -1; i--)
        {
            if(rowCells[i].isTrue)
            {
                rowValue++;
                ammountTexts[textID].text = rowValue.ToString();
            }
            else if(!rowCells[i].isTrue && rowValue > 0)
            {
                rowValue = 0;
                textID++;
            }
        }

        //si los textos son 0, pasan a ser "vacios"
        foreach(Text ammountText in ammountTexts)
        {
            if(ammountText.text == "0") ammountText.text = "";
        }
    }
}
