using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public Camera getCamera;

    public MeshRenderer nuclPic;
    public GameObject nucltra;
    public TextMesh nuclText;

    public MeshRenderer facPic;
    public TextMesh facText;

    public MeshRenderer hosPic;
    public TextMesh hosText;

    public MeshRenderer hostraPic;
    public TextMesh hostraText;

    public MeshRenderer traPic;
    public TextMesh traText;

    public MeshRenderer facsoilPic;

    public MeshRenderer covidPic;

    public Texture[] PicMat;

    // 레이케스트가 건드린(?) 것을 취득해서 넣어두는곳
    private RaycastHit hit;

    void Update()
    {
        // 마우스 클릭을 하면~
        if(Input.GetMouseButtonDown(0))
        {
            // 마우스 포지션을 취득해서 대입해
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            // 마우스 포지션에서 레이를 던져서 뭔가가 걸리면 hit에 넣음
            if(Physics.Raycast(ray, out hit))
            {
                // 오브젝트명을 취득해서 변수에 넣음
                string objTag = hit.collider.gameObject.tag;
                // 오브젝트명을 콘솔에 표시해줌
                if (objTag == "nucl")
                {
                    nuclPic.material.mainTexture = PicMat[0];
                    nucltra.SetActive(false);
                    nuclText.text = "고리 핵융합 발전소";
                }
                if (objTag == "fac")
                {
                    facPic.material.mainTexture = PicMat[1];
                    facText.text = "온산 공단(불가사리 제설제)";
                }
                if (objTag == "hos")
                {
                    hosPic.material.mainTexture = PicMat[2];
                    hosText.text = "울산대학교 병원(수술 성공률 100%!)";
                }
                if (objTag =="tra")
                {
                    traPic.material.mainTexture = PicMat[3];
                    traText.text = "공업탑(컨트롤 타워)";
                }
                if (objTag == "hostra")
                {
                    hostraPic.material.mainTexture = PicMat[4];
                    hostraText.text = "재활용!";
                }
                if (objTag == "facsoil")
                {
                    facsoilPic.material.mainTexture = PicMat[5];
                }
                if (objTag =="covid")
                {
                    covidPic.material.mainTexture = PicMat[6];
                }
            }
        }
    }
}
