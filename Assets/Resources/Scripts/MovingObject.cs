using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField]
    GameObject[] targets;

    int currentPoint = 0;
    float speed = 0.1f;
    bool complete;

    public bool moving;
    // Start is called before the first frame update
    void Start()
    {
        print("Hi Terrance!");
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            // While it hasn't hit all 3 points
            if (!complete)
            {
                Transform target = targets[currentPoint].transform;
                float step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                // Check if the position of the cube and capsule are approximately equal.
                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    // Move the position of the capsule.
                    currentPoint++;
                }
            }
            if (currentPoint >= targets.Length)
            {
                this.gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                complete = true;
            }
        }
        
    }
}
