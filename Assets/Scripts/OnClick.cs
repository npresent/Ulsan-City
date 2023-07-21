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

    // �����ɽ�Ʈ�� �ǵ帰(?) ���� ����ؼ� �־�δ°�
    private RaycastHit hit;

    void Update()
    {
        // ���콺 Ŭ���� �ϸ�~
        if(Input.GetMouseButtonDown(0))
        {
            // ���콺 �������� ����ؼ� ������
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            // ���콺 �����ǿ��� ���̸� ������ ������ �ɸ��� hit�� ����
            if(Physics.Raycast(ray, out hit))
            {
                // ������Ʈ���� ����ؼ� ������ ����
                string objTag = hit.collider.gameObject.tag;
                // ������Ʈ���� �ֿܼ� ǥ������
                if (objTag == "nucl")
                {
                    nuclPic.material.mainTexture = PicMat[0];
                    nucltra.SetActive(false);
                    nuclText.text = "�� ������ ������";
                }
                if (objTag == "fac")
                {
                    facPic.material.mainTexture = PicMat[1];
                    facText.text = "�»� ����(�Ұ��縮 ������)";
                }
                if (objTag == "hos")
                {
                    hosPic.material.mainTexture = PicMat[2];
                    hosText.text = "�����б� ����(���� ������ 100%!)";
                }
                if (objTag =="tra")
                {
                    traPic.material.mainTexture = PicMat[3];
                    traText.text = "����ž(��Ʈ�� Ÿ��)";
                }
                if (objTag == "hostra")
                {
                    hostraPic.material.mainTexture = PicMat[4];
                    hostraText.text = "��Ȱ��!";
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
