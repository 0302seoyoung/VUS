using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class WearingEquipment : MonoBehaviour
{
    EquipmentData equipmentData;            //������ ����� ������
    [SerializeField]EQUIPMENTTYPE equipType;//�ش� ĭ�� ���� Ÿ��
    [SerializeField] Sprite[] sprite;       //������ �̹��� 
    [SerializeField] Image img;             //�ش� ĭ �̹��� ��ȯ 
    [SerializeField] string path;           //�ش� ĭ�� ��� ����
    [SerializeField] GameObject wearingEquipInfo;
    [SerializeField] GameObject Blocker;
    private void Start()
    {
        DataLoad();
    }

    void DataLoad() //������ �ε� ����
    {
        string filePath = Path.Combine(Application.dataPath, path);

        if (File.Exists(filePath))
        {
            // JSON ���� �б�
            string jsonData = File.ReadAllText(filePath);

            // JSON �����͸� EquipmentData ��ü�� ��ȯ
            equipmentData = JsonUtility.FromJson<EquipmentData>(jsonData);
            img.sprite = sprite[equipmentData.id];
        }
        else
        {
            Debug.LogError("Cannot find JSON file at " + filePath);
        }
    }
    
    public void ShowButton()//�����͸� �����ִ� ��ư 
    {
        Blocker.GetComponent<Canvas>().sortingOrder += 1;
        wearingEquipInfo.SetActive(true);
        wearingEquipInfo.transform.GetChild(2).GetComponent<Text>().text = equipmentData.name;
        wearingEquipInfo.transform.GetChild(5).GetComponentInChildren<Text>().text =
            $"{((equipmentData.attackPower != 0) ? "���ݷ� : + " + equipmentData.attackPower + "\n" : null)}" +
            $"{((equipmentData.magicPower != 0) ? "�ֹ��� : + " + equipmentData.magicPower + "\n" : null)}" +
            $"{((equipmentData.speed != 0) ? "�̵� �ӵ� : + " + equipmentData.speed + "\n" : null)}" +
            $"{((equipmentData.maxHp != 0) ? "��ü��ȭ : + " + equipmentData.maxHp/10 + "\n" : null)}" +
            $"{((equipmentData.cri != 0) ? "ġ��Ÿ : + " + equipmentData.cri + "\n" : null)}" +
            $"{((equipmentData.criDmg != 0) ? "ġ��Ÿ ������ : + " + equipmentData.criDmg + "\n" : null)}";
        SynergySort();
    }

    void SynergySort()
    {
        switch (equipmentData.synergy)
        {
            case EQUIPMENTSYNERGY.NONE:
                for (int i = 0; i < 6; i++)
                {
                    wearingEquipInfo.transform.GetChild(6).GetChild(i).GetComponent<Text>().text = null;
                }
                break;
            default:
                break;
        }
    }
}
