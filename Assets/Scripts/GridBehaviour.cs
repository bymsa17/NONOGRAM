using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GridBehaviour : MonoBehaviour
{
    //Definir el tamaño del tablero
    public enum Size { cinco, diez, quince, veinte, veinticionco };
    public Size size;

    public RectTransform InsideGrid;

    //Añadir cuadros a la grid en función del tamaño
    public GameObject buttonOriginal;
    public RectTransform grupoGrid;
    public GameObject newButton;

    public int maxSize;
    public int totalButtons;
    public int numSize;

    public int[] numValue;

    public Text[] text;
    
    // Start is called before the first frame update
    void Start()
    {
        numSize = 5;
        text = GetComponentsInChildren<Text>();
        numValue = new int[numSize];
        for(int i = 0; i < numSize; i++)
        {
            numValue[i] = UnityEngine.Random.Range(1, 5);
            text[i].text = numValue[i].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(size)
        {
            case Size.cinco:
                {
                    //Limite de tamaño
                    InsideGrid.sizeDelta = new Vector2(500, 500);
                    numSize = 5;
                    maxSize = numSize * numSize;

                    //Condición si el tamaño de la grid es inferior
                    if(totalButtons < maxSize)
                    {
                        totalButtons += 1;

                        //Añadimos cuadros a la grid base
                        newButton = Instantiate(buttonOriginal, grupoGrid);
                    }
                }
                break;
            case Size.diez:
                {
                    //Limite de tamaño
                    InsideGrid.sizeDelta = new Vector2(1000, 1000);
                    numSize = 10;
                    maxSize = numSize * numSize;

                    //Condición si el tamaño de la grid es inferior
                    if(totalButtons < maxSize)
                    {
                        totalButtons += 1;

                        //Añadimos cuadros a la grid base
                        newButton = Instantiate(buttonOriginal, grupoGrid);
                    }
                }
                break;
            case Size.quince:
                {
                    //Limite de tamaño
                    InsideGrid.sizeDelta = new Vector2(1500, 1500);
                    numSize = 15;
                    maxSize = numSize * numSize;

                    //Condición si el tamaño de la grid es inferior
                    if(totalButtons < maxSize)
                    {
                        totalButtons += 1;

                        //Añadimos cuadros a la grid base
                        newButton = Instantiate(buttonOriginal, grupoGrid);
                    }
                }
                break;
            case Size.veinte:
                {
                    //Limite de tamaño
                    InsideGrid.sizeDelta = new Vector2(2000, 2000);
                    numSize = 20;
                    maxSize = numSize * numSize;

                    //Condición si el tamaño de la grid es inferior
                    if(totalButtons < maxSize)
                    {
                        totalButtons += 1;

                        //Añadimos cuadros a la grid base
                        newButton = Instantiate(buttonOriginal, grupoGrid);
                    }
                }
                break;
            case Size.veinticionco:
                {
                    //Limite de tamaño
                    InsideGrid.sizeDelta = new Vector2(2500, 2500);
                    numSize = 25;
                    maxSize = numSize * numSize;

                    //Condición si el tamaño de la grid es inferior
                    if(totalButtons < maxSize)
                    {
                        totalButtons += 1;

                        //Añadimos cuadros a la grid base
                        newButton = Instantiate(buttonOriginal, grupoGrid);
                    }
                }
                break;
        }
    }
}
