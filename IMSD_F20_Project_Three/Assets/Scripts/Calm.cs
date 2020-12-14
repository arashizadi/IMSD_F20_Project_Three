using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calm : MonoBehaviour
{
    GameManager GameManager;
    public int stressReduction;
    public GameObject orbHelper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        GameManager.stress -= stressReduction;
        gameObject.SetActive(false);
    }
    private void OnMouseEnter()
    {
        orbHelper.SetActive(true);
    }

    private void OnMouseExit()
    {
        orbHelper.SetActive(false);

    }


}
