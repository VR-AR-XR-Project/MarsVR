using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class BlackHoleSphere : MonoBehaviour
{
	public string sceneName = "";

	private Material mat;
	private Transform m_tansform;

	private void Start()
	{
		mat = GetComponent<MeshRenderer>().sharedMaterial;
		m_tansform = transform;
	}

	private void Update()
	{
		mat.SetVector("_Center", new Vector4(m_tansform.position.x, m_tansform.position.y, m_tansform.position.z, 1f));
	}

	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.layer == 3)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
