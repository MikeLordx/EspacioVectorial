using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity=0;
    public float rotation;
    public float timer=0;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //transform.position += new Vector3(0, Mathf.Sin(time), 0);

    
        
        if(velocity==0)
        {
            if (timer <= 2)
            {
                subida();

            }

            if (timer >= 2)
            {
                bajada();
                if (timer >= 4)
                {
                    timer = 0;
                }
            }

        }

        if (Input.GetKey(KeyCode.W))
        {
            velocity = 5;
            transform.position += Vector3.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            velocity = 0;
        }


        if (Input.GetKey(KeyCode.S))
        {
            velocity = 5;
            transform.position += Vector3.back * velocity * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            velocity = 0;
        }


        if (Input.GetKey(KeyCode.D))
        {
            velocity = 5;
            transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            velocity = 0;
        }


        if (Input.GetKey(KeyCode.A))
        {
            velocity = 5;
            transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            velocity = 0;
        }


        if (Input.GetKey(KeyCode.E))
        {
            rotation += Time.deltaTime * 40;
            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotation -= Time.deltaTime * 40;
            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }

    }
    void subida()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * 1);

    }

    void bajada()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 1);
    }

}
