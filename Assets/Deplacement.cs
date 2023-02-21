using UnityEngine;

public class Deplacement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * 60);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * 60);
        
        
        
        
    }
}
