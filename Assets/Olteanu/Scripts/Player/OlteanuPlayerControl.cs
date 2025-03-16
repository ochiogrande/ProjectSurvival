using UnityEngine;

public class OlteanuPlayerControl : MonoBehaviour
{
    public float vitezaDeMiscare;


    private void Update()
    {
        Vector3 miscareDeInput = new Vector3(0f, 0f, 0f);

        miscareDeInput.x = Input.GetAxisRaw("Horizontal");
        miscareDeInput.y = Input.GetAxisRaw("Vertical");

        miscareDeInput.Normalize();
        transform.position += miscareDeInput * vitezaDeMiscare * Time.deltaTime;
    }
}
