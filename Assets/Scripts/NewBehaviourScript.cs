using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float AddForce = 200f;
    public float SideWays = 200f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, AddForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, SideWays * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -SideWays * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
