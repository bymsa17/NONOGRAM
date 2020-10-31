using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayBehaviour : MonoBehaviour
{

    //Este script es el update que gestiona el funcionamiento del resto de updates del juego e inicializa el resto de updates en orden

    public Grid grid;

    public static int ramainingLifes = 3;

    public static bool usingFillAction = true;

    public static bool gamePaused = false;

    public GameObject fillIcon;
    public GameObject crossIcon;

    public float elapsedTime = 0;


    void Start()
    {
        //Administrar iconos de acción
        fillIcon.SetActive(true);
        crossIcon.SetActive(false);

        //Inicializar la grid
        grid = FindObjectOfType<Grid>();
        grid.Initialize();
    }

    void Update()
    {
        if(!gamePaused)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {

        }
    }

    public void ChangeAction()
    {
        usingFillAction = !usingFillAction;

        if(usingFillAction)
        {
            fillIcon.SetActive(true);
            crossIcon.SetActive(false);
        }
        else
        {
            fillIcon.SetActive(false);
            crossIcon.SetActive(true);
        }
    }
}