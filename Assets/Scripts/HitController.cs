using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    [SerializeField]
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log($"点击的位置y坐标是{hit.point.y}");
                Debug.Log($"{hit.point.y == 0.00}");
                if (hit.point.y < 0.001) 
                {
                    Debug.Log("进来执行生成");
                    Vector3 position = new Vector3(hit.point.x,0.5F, hit.point.z);
                    Instantiate(cubePrefab,position,Quaternion.identity);
                }
            }
        }
    }
}
