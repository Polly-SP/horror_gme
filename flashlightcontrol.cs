using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightcontrol : MonoBehaviour
{
    public GameObject Flashlight;               //	Префаб фонарика (чтобы	иметь возможность	спрятать	его	или	наоборот достать)
    public Light _flashlightLight;              //	Сохраняем компонент Light в переменную	для	удобства	обращения
    public float FlashlighMaxPower = 100;         //  Текущий заряд фонарика
    public float FlashlightMinus = 0.05f;       //	Расход заряда фонарика	в один кадр
    

    // Функция выполняется каждый кадр (при 60 FPS - 60 кадров в секунду) т.е. 60 раз в секунду выполняется 
    void Update()
    {

        FlashlighMaxPower -= FlashlightMinus
            ;     // Отнимать заряд фонарика с шагом в FlashlightMinus
        _flashlightLight.intensity -= 0.001f;  // Отнимать интенсивность света каждый кадр

        // Если заряд фонаря меньше 0
        if (FlashlighMaxPower < 0)
        {
            FlashlighMaxPower = 0;                // То заряд фонаря равен 0
            _flashlightLight.intensity = 0;     // Погасить фонарик
        }
    }
}
