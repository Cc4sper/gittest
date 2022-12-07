using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemoveleft: MonoBehaviour
{
   
    int paddle = 4;
    [SerializeField] KeyCode up;
    [SerializeField] KeyCode down;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y <= -1.8 && Input.GetKey(up))
        {
            transform.position += new Vector3(0, paddle, 0) * Time.deltaTime;
        }
        
       if(transform.position.y >= -8.2 && Input.GetKey(down))
        {
            
          transform.position -= new Vector3(0, paddle, 0) * Time.deltaTime;
            
        }
    }
}
