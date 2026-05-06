using UnityEngine;

public class CharacterController : BaseEntity, IDamageable, IInteractable
{
    public void TakeDamage()
    {

    }

    public void Interact()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.GetComponent<ICollectable>() != null)
        {

            collision.gameObject.GetComponent<ICollectable>().Collect();
        }
    }
}