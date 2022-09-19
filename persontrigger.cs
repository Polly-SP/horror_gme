using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persontrigger : MonoBehaviour
{
    public GameObject ppl;   // Объект человек
    public AudioSource AppearSFX; // Сохраняем в переменную компонент AudioSource;

    private void OnTriggerEnter(Collider other) // Если ЧТО TO вошло в триггер

    {
        if (other.tag == "Player") // Если ЧТО TO имеет тэг Player (а его имеет только игрок)
        {
            ppl.SetActive(true); // Показать модель человек 
            AppearSFX.Play();	// Проиграть звук в AudioSource;
            Destroy(ppl,1); // Удалить объект через 1 секунду
        }
    }
}