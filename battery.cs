using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour
{
    public AudioSource PickupSFX; // Сохраняем в переменную компонент AudioSource;

    // Если ЧТО ТО попало в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Если это ЧТО ТО имеет тэг Player
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<flashlightcontrol>().FlashlighMaxPower += 50; // Прибавить заряд фонарю по 50
            GameObject.FindGameObjectWithTag("Player").GetComponent<flashlightcontrol>()._flashlightLight.intensity = 2.5f; // Восстановить яркость фонаря
            PickupSFX.Play();   // Проиграть звук в AudioSource;
            Destroy(gameObject,1); // Удалить объект через 1 секунду
        }
    }


}