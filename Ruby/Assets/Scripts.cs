using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;

        //Esto hara que el movimiento del personaje vaya mas lenta, a 10 fotográmas por segundo. 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//movimiento en horizontal
        Debug.Log("Se ha movido en horizontal");

        float vertical = Input.GetAxis("Vertical");//movimiento en vertical
        Debug.Log("Se ha movido en vertical");
        Debug.Log(horizontal);// muestra el valor actual en el eje horizontal
        Vector2 position = transform.position;// declara la variable position y guarda la posicion actual de Ruby
       
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;//el personaje se moverá en el eje x
        position.y = position.y + 3.0f * vertical * Time.deltaTime;//el personaje se movera en el eje y
        transform.position = position;//actaliza la posicion calculada anteriormente
    }
}
