using UnityEngine;

public class CloudsMovement : MonoBehaviour
{
    [SerializeField] GameObject m_Cloud;

    public float speed;

    [SerializeField] GameObject m_End;
    [SerializeField] GameObject m_Start;
    
    [System.Obsolete]
    void Update()
    {
        MoveClouds();
    }

    [System.Obsolete]
    private void MoveClouds()
    {
        m_Cloud.transform.position = Vector3.MoveTowards(m_Cloud.transform.position, m_End.transform.position, Time.deltaTime * speed);

        if (m_Cloud.transform.position == m_End.transform.position)
        {
            m_Cloud.transform.position = new  Vector3(m_Start.transform.position.x, m_Start.transform.position.y);
        }
    }
}
