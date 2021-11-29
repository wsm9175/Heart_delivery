using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiTrackedImageManager : MonoBehaviour
{
    [SerializeField]
    ARTrackedImageManager mgr;

    [SerializeField]
    GameObject[] m_objList;

    public GameObject ARSession1;
    public GameObject ARSession2;

    public GameObject canvasMenuKor;
    public GameObject canvasMenuUSA;
    public GameObject canvasMenuITA;
    public GameObject canvasMenuFRN;
    public GameObject canvasShooting;

    // key,vlaue 의 쌍
    Dictionary<string, GameObject> m_dic = new Dictionary<string, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        //오브젝트의 이름으도 등록(검색용)
        foreach (var i in m_objList) {
            m_dic.Add(i.name, i);
        }
    }

    // 이 스크립트가 활성화 될 때 호출된다.
    private void OnEnable()
    {
        mgr.trackedImagesChanged += MyChangeImg;
    }

    private void OnDisable()
    {
        mgr.trackedImagesChanged += MyChangeImg; 
    }

    void MyChangeImg(ARTrackedImagesChangedEventArgs _args) {
        foreach(var i in m_objList) {
            var obj = i;
            obj.SetActive(false);
        }

        foreach (var i in _args.added) {
            // 추적용 이미지의 이름을 가지고, 활성화할 오브젝트를 찾는다.
            var objTrans = m_dic[i.referenceImage.name];

            objTrans.transform.SetParent(i.transform);
            objTrans.transform.localPosition = Vector3.zero;
            objTrans.transform.localRotation = Quaternion.identity;
            objTrans.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
