using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    public Light _light;        // Сохраняем компонент Light в переменную для удобства обращения
    public float timer;         // Переменная с дробными числами

    void Start()
    {
        StartCoroutine(FlickeringLight());      // Запускаем примитивный таймер(не в секундах) и мерцание света
    }

    IEnumerator FlickeringLight()
    {
        _light.intensity = Random.Range(0, 0.2f);   // Изменить яркость света в диапазоне от 0 до 0.2
        timer = Random.Range(0.1f, 1);              // Обновить значение переменной Timer
        yield return new WaitForSeconds(timer);     // Подождать X секунд. X берётся из переменной timer
        
    _light.intensity = Random.Range(0.1f, 1f);      // Аналогично тому что выше
        timer = Random.Range(0.1f, 1);
        yield return new WaitForSeconds(timer);
        
    StartCoroutine(FlickeringLight()); // Запустить эту корутину снова
    }
}
