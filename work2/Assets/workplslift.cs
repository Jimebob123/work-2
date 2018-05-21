using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class workplslift : MonoBehaviour
{
    public bool moved;
    public float speed;
    Vector3 pos;
    public float destination;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moved && gameObject.transform.position.y <= destination)
        {
            pos = gameObject.transform.position;
            pos += Vector3.up * Time.deltaTime * speed;
            gameObject.transform.position = pos;
        }
        if (moved && gameObject.transform.position.y >= destination)
        {
            if (gameObject.transform.eulerAngles.x <= 100)
            {
                gameObject.transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));

                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                audio.Play(44100);
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {

        if (moved == false)
        {
            moved = true;

        }
    }
}
