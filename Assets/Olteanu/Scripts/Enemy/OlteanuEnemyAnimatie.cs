using UnityEngine;

public class OlteanuEnemyAnimatie : MonoBehaviour
{
    [SerializeField] Transform sprite;
    [SerializeField] float viteza;
    [SerializeField] float marimeMinima, marimeMaxima;
    [SerializeField] float marimeActiva;

    private void Start()
    {
        marimeActiva = marimeMaxima;
    }

    private void Update()
    {
        sprite.localScale = Vector3.MoveTowards(sprite.localScale, Vector3.one * marimeActiva, viteza * Time.deltaTime);
        if(sprite.localScale.x == marimeActiva)
        {
            if(marimeActiva  == marimeMaxima)
            {
                marimeActiva = marimeMinima;
            }
            else
            {
                marimeActiva = marimeMaxima;
            }
        }
    }
}
