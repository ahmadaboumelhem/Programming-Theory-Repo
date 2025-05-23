using UnityEngine;

public class Shape : MonoBehaviour
{
    private int m_scoreValue;
    protected int scoreValue // ENCAPSULATION
    {
        get { return m_scoreValue; }
        set
        {
            if (value < 1)
            {
                Debug.LogError("Score value has to be a positive integer!");
            }
            else
            {
                m_scoreValue = value;
            }
        }
    }

    public virtual void OnClick()
    {
        DestroyShape();
    }

    private void OnMouseDown()
    {
        OnClick();
    }

    void Update()
    {
        if (transform.position.y < -10 || transform.position.y > 10 || transform.position.x < -10 || transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    protected void DestroyShape() // ABSTRACTION
    {
        ScoreManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }

    protected void ShootShape() // ABSTRACTION
    {
        ScoreManager.Instance.AddScore(scoreValue);
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    protected void DropShape() // ABSTRACTION
    {
        ScoreManager.Instance.AddScore(scoreValue);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
