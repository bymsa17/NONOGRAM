using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellBehaviour : MonoBehaviour
{
    public enum State { Empty, Fill, Cross}
    public State state = State.Empty;
    public bool isTrue = false;

    public GameObject fillIcon;
    public GameObject crossIcon;

    public Text debugText; //ERASE

    public void Initialize(bool trueValue)
    {
        isTrue = trueValue;

        debugText.text = trueValue.ToString();
    }

    public void ResetCell()
    {
        ActualiceState(0);
    }

    public void ClickCell()
    {
        if(GameplayBehaviour.usingFillAction) FillCell();
        else CrossCell();
    }

    void FillCell()
    {
        if(state != State.Fill) ActualiceState(1);
        else ResetCell();
    }
    void CrossCell()
    {
        if(state != State.Cross) ActualiceState(2);
        else ResetCell();
    }

    void ActualiceState(int type)
    {
        if(type == 0)
        {
            state = State.Empty;
            fillIcon.SetActive(false);
            crossIcon.SetActive(false);
        }
        else if(type == 1)
        {
            state = State.Fill;
            fillIcon.SetActive(true);
            crossIcon.SetActive(false);
        }
        else if(type == 2)
        {
            state = State.Cross;
            fillIcon.SetActive(false);
            crossIcon.SetActive(true);
        }

        //TODO: llama a actualizar las rows para apagar o encender los numeros o autocompletar cruces en las casills
    }
}