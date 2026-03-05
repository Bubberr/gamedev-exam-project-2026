using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    public int damage = 10;
    private bool m_isActive = false;

    public void EnableHitbox()  { m_isActive = true; }
    public void DisableHitbox() { m_isActive = false; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!m_isActive) return;

        IAttackable target = other.GetComponent<IAttackable>();
        if (target != null)
            target.TakeDamage(damage);
    }
}