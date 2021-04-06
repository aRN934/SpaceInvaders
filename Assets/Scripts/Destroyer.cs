using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        // se for só Destroy(gameObject); destrói a si próprio, com "collision" é o outro objecto
    }
}
