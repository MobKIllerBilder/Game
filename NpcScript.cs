using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    // Задаём целочисленную переменную health, равную 5
    public int health = 5;
    // Задаём целочисленную переменную level, равную 3
    public int level = 3;
    // Задаём дробную переменную health, равную 1.5
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Теперь у нас переменная health постоянно будет увеличиваться на значение переменной level
        health += level;
        // Выводим значение переменной health
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 — это особый тип данных, который отвечает за положение объектов
        //Transform — это знакомый тебе компонент объекта, а Position — одно из его свойств.
        Vector3 newPosition = transform.position;
        //Изменяем значение переменной newPosition, чтобы объект двигался
        newPosition.x += speed * Time.deltaTime;
        //Изменяем значение яtransform.position на новые
        transform.position = newPosition;
    }
}
