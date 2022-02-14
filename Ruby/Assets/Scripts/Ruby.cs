using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    public float speed = 3.0f;

    Rigidbody2D rb;

    public int maxHealth = 5;

    int currentHealth;

    public int health { get { return currentHealth; } }//define la propiedad en el script.


    public float timerInvencible = 2.0f;
    bool isInvencible;
    float invicibleTimer;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();//va a atener acceso al contenido de rigidBOdy2D. 

        //Esto hara que el movimiento del personaje vaya mas lenta, a 10 fotográmas por segundo. 

        currentHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//movimiento en horizontal
        Debug.Log("Se ha movido en horizontal");

        float vertical = Input.GetAxis("Vertical");//movimiento en vertical
        Debug.Log("Se ha movido en vertical");
        Debug.Log(horizontal);// muestra el valor actual en el eje horizontal

        Vector2 position = rb.position;// declara la variable position y guarda la posicion actual de Ruby

        position.x = position.x + 3.0f * horizontal * Time.deltaTime;//el personaje se moverá en el eje x
        position.y = position.y + 3.0f * vertical * Time.deltaTime;//el personaje se movera en el eje y
        
        transform.position = position;//actaliza la posicion calculada anteriormente


        rb.MovePosition(position);
        // Permitirá mover el rigidbody para donde nosotros queramos, pero se detendrá cuando se tope con un collider.

        if (isInvencible)
        {
            invicibleTimer -= Time.deltaTime;
            if

        }






    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);

        Debug.Log(currentHealth + " / " + maxHealth);
    }
}
