using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField]
    GameObject fire;

    [SerializeField]
    Transform nozzle;

    [SerializeField]
    float velocidade = 5f;

    float minX, maxX;

    void Start()
    {
        // 0.5 é a margem da nave
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.5f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.5f;

        //Debug.Log(bottomLeftWorld);
        //Debug.Log(topRightWorld);
    }


    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, nozzle.position, nozzle.rotation);
            //.position e .rotation é para "des-herdar" o filho
        }


        float hMov = Input.GetAxis("Horizontal");
        //Debug.Log(hMov);
        transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;


        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ProjectilInimigo")
            Destroy(gameObject);
        Destroy(collision.gameObject);

    }


}
