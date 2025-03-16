using UnityEngine;

public class OlteanuPlayerControl : MonoBehaviour
{
    public float moveSpeed;

    private void Update()
    {
        Vector3 moveInput = new Vector3(0f, 0f, 0f);
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
        transform.position += moveInput * moveSpeed * Time.deltaTime;
    }
}
