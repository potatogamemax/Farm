using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float HorizontalInput;
    [SerializeField] float speed=10.0f;
    [SerializeField] float xRange=10.0f;
    [SerializeField] GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        HorizontalInput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if(transform.position.x > xRange)
        {
            transform.position=new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
