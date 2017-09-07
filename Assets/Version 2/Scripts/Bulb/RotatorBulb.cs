using UnityEngine;
using System.Collections;

public class RotatorBulb : MonoBehaviour
{
	public Vector3 origin;
    public Vector3 velocity = new Vector3(-8, 0);
    public float range = 4;

    public float tumble;
    private Rigidbody rb;
    private Renderer rn;

   public  float speed;

    void Start()

    {
        InvokeRepeating("colorRandom", 0, 20.0f);
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
        // rb.velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);

    }

    float maxMoveDistance = 10;

    Color colorPicker(int i)
    {
        if (i == 1)
        {
            return Color.red;
        }
        if (i == 2)
        {
            return Color.yellow;
        }
        if (i == 3)
        {
            return Color.green;
        }

        if (i == 4)
        {
            return Color.magenta;
        }
        if (i == 5)
        {
            return Color.cyan;
        }
        return Color.blue;
    }

    void colorRandom()
    {
      //  int j = Random.Range(0, 5);

     //   Color color = colorPicker(j);

       // rn = GetComponentInChildren<Renderer>();
       // rn.material.color = color;
    }


  

    void Update()

    {

        Vector3 destination = origin;
        destination.z = (transform.position.z > origin.z + maxMoveDistance) ? origin.z : origin.z - maxMoveDistance;
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }

   

    public GameObject Explosion;
    
    




}







