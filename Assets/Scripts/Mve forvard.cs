using UnityEngine;

public class Mveforvard : MonoBehaviour
{
    [SerializeField] float speed = 40f;// Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
