using UnityEditor.Searcher;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //getting input here 
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(input.magnitude > 0)
        {
            //multiplying movement by Time.deltaTime to make it run smoother no matter how many frames per second the device can do 
            Vector2 movement = input.normalized * (movementSpeed * Time.deltaTime);
            //makes the actual movement
            transform.Translate(movement, Space.World);

            float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0,0,angle);


        }

    }
}
