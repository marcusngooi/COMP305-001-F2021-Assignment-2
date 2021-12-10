using System.Collections;
using UnityEngine;

public class RollingPlatformController : MonoBehaviour
{
    // "Public" variables
    [SerializeField] private GameObject player;
    [SerializeField] private PhysicsMaterial2D material;
    [SerializeField] private GameObject frontWheel;
    [SerializeField] private GameObject backWheel;

    public void Start()
    {
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //other.transform.parent = transform;
            //player.AddComponent<FixedJoint2D>();
            //FixedJoint2D fixedJoint2D = player.GetComponent<FixedJoint2D>();
            //fixedJoint2D.connectedBody = GetComponent<Rigidbody2D>();
            
            frontWheel.GetComponent<WheelJoint2D>().useMotor = true;
            backWheel.GetComponent<WheelJoint2D>().useMotor = true;
            //StartCoroutine(AccelerateRollingPlatform());
            //frontWheel.GetComponent<WheelJoint2D>().useMotor = false;
            //backWheel.GetComponent<WheelJoint2D>().useMotor = false;
            Destroy(other.transform.GetComponent<Rigidbody2D>());
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        //other.transform.parent = null;
        //Rigidbody2D rBody = player.AddComponent<Rigidbody2D>();
        //rBody.sharedMaterial = material;
    }

    IEnumerator AccelerateRollingPlatform()
    {
        yield return new WaitForSeconds(10f);
    }
}
