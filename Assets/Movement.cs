using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int XForce;
    public int YForce;
    public Rigidbody2D rg2D;

    Vector2 TotalForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalForce = new Vector2(XForce, YForce);

        if (Input.GetKey(KeyCode.Mouse0) && XForce < 350)
        {
            rg2D.drag = 0;
            XForce++;
            YForce++;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            rg2D.drag = 0;
            rg2D.AddForce(TotalForce);

            XForce = 0;
            YForce = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(Input.GetKey(KeyCode.Mouse0) == false)
        {
            rg2D.drag = 1000000;

            rg2D.velocity = new Vector2(0, 0);
        }
        
    }
}
