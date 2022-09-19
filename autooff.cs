using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autooff : MonoBehaviour
{
public float TimeCur = 60;  // "Время" (HE В СЕКУНДАХ!). Когда оно кончится, что то произойдёт
public float TimeStep = 1; // С каким шагом истекает "таймер" TimeCur;

public GameObject offit; //Объект который необходимо отключить

// Update is called once per frame 
    void Update ()
    {
       //	Каждый кадр проверять,	если время ещё не вышло, то убавлять его со значением TimeStep
        if	(TimeCur > 0)
        { TimeCur -= TimeStep; }
        else // если время вышло, то
        {
            offit.SetActive(false); // Отключить объект из переменной
            TimeCur = 0; // Остановить таймер и не дать ему опуститься ниже нуля
        }
    }
}