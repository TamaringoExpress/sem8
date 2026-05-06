using UnityEngine;
public interface IDamageable
{
    public abstract void TakeDamage();

}
public interface IInteractable
{
    public virtual void Interact()
    {
        Debug.Log("interact");
    }
}

public interface ICollectable
{
    public virtual void Collect()
    {
        Debug.Log("collect");
    }
}