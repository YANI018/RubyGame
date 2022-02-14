using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollection : MonoBehaviour
{
     

     void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Objeto en el trigger: " + other);

        Ruby controller = other.GetComponent<Ruby>();


        if (controller != null)

        {
           if (controller.health < controller.maxHealth)
            {

                controller.ChangeHealth(1);
                Destroy(gameObject);

            }

        }
    }
}
