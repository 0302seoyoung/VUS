using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EquipmentData//��� ������
{
    public string name;             //��� �̸� 
    public string info;             //����� ����
    public int level;               //��� ����
    public int id;                  //��� ���̵�
    //��ȭ�� �� �ִ� �ɷ�ġ => ��ȭ���� �� ���� �������� ��� ������ 10% ����
    public float attackPower;
    public float magicPower;
    public float speed;
    public float maxHp;
    public float maxMp;
    public float dp;
    public float mr;
    public float cri;
    public float criDmg;

    public int upgradeCost;         //���׷��̵� �ϴµ� �ʿ��� ���

    public EQUIPMENTTYPE type;      //��� Ÿ�� 
    public EQUIPMENTSYNERGY synergy;//��� �ش��ϴ� �ó���
    public EQUIPMENTSKILL skill;    //���� ��ų
}
