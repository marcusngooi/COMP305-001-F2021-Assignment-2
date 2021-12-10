using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingPlatformController : MonoBehaviour
{
    // Private variables
    Animator anim;
    private bool isCollapsing = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("isCollapsing", isCollapsing);
    }

    public void DestroyPlatform()
    {
        Destroy(this.gameObject);
    }
}
