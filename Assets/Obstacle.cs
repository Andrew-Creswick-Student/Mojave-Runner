using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float cutOffX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = (Vector2.left * moveSpeed * Time.deltaTime, 0);
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if(transform.position.x <= cutOffX)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health.TryDamageTarget(collision.gameObject, 1);
    }
}
