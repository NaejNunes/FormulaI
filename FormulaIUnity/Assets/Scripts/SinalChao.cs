using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinalChao : MonoBehaviour
{
    public float velocidadeSinal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * velocidadeSinal * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LimiteBaixo"))
        {
            Destroy(gameObject);
        }
    }
}
