using UnityEngine;

public class OlteanuEnemyControl : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float vitezaDeMiscare;
    [SerializeField] Transform target;
    public float damage;
    [SerializeField] float asteaptaSaHitTimp = 1f;
    [SerializeField] float contuar;

    private void Start()
    {
        target = FindObjectOfType<OlteanuPlayerControl>().transform;

        vitezaDeMiscare = vitezaDeMiscare * Random.Range(0.75f, 1.25f);
    }

    private void Update()
    {
        rb.linearVelocity = (target.position - transform.position).normalized * vitezaDeMiscare;
        if(contuar > 0f)
        {
            contuar -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && contuar <= 0f)
        {
            OlteanuPlayerViataControl.instance.PrimesteDamage(damage);
            contuar = asteaptaSaHitTimp;
        }
    }
}
