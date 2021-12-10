using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatformController : MonoBehaviour
{
    // "Public" variables
    [SerializeField] private float bounce = 20.0f;

    // Private variables
    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animation.Play();
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f , 0.0f);
            other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
