using UnityEngine;
using System.Collections;

public class DragLetter_4 : MonoBehaviour
{

    public DisPoint dispoint;
    public Level_4 limit;
    private float min;
    private int j;

    // Use this for initialization  
    void Start()
    {
        PlaceLetter();
    }

    // Update is called once per frame  
    void Update()
    {
        int num = dispoint.point.Length;
        float[] dis = new float[num];

        for (int i = 0; i < num; i++)
        {
            dis[i] = Vector3.Distance(transform.position, dispoint.point[i].transform.position);
        }

        min = Mathf.Min(dis);
        for (int i = 0; i < num; i++)
        {
            //在松开鼠标的时候如果字母和格子的距离过远将不会改变当前位置
            if (min == dis[i] && min < 0.5)
            {
                j = i;
            }
        }
    }


    //下面的函数是当鼠标触碰到碰撞体或者刚体时调用，我的碰撞体设置是mesh collider，然后别忘了，给这个collider添加物理材质  

    //值得注意的是世界坐标系转化为屏幕坐标系，Z轴是不变的  
    IEnumerator OnMouseDown()
    {
        if (limit.operatable)
        {
            //在鼠标拖动的过程中字母的父节点会自动改变，防止两次同一个字母进入同一个区域的时候发生检测子物体错误
            //this.transform.parent = WatingArea.transform;

            //将物体由世界坐标系转化为屏幕坐标系 ，由vector3 结构体变量ScreenSpace存储，以用来明确屏幕坐标系Z轴的位置  
            Vector3 ScreenSpace = Camera.main.WorldToScreenPoint(transform.position);
            //完成了两个步骤，1、由于鼠标的坐标系是2维的，需要转化成3维的世界坐标系，2、只有三维的情况下才能来计算鼠标位置与物体的距离，offset即是距离  
            Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z));

            //当鼠标左键按下时 
            while (Input.GetMouseButton(0))
            {
                //得到现在鼠标的2维坐标系位置  
                Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z);
                //将当前鼠标的2维位置转化成三维的位置，再加上鼠标的移动量  
                Vector3 CurPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
                //CurPosition就是物体应该的移动向量赋给transform的position属性        
                transform.position = CurPosition;
                //这个很主要  
                yield return new WaitForFixedUpdate();
            }
        }

    }

    void OnMouseUp()
    {
        if (limit.operatable)
        {
            if (this.name == "A")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RA")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "B")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RB")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "C")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RC")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "D")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RD")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "E")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RE")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "F")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RF")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "G")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RG")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "H")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RH")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "I")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RI")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "J")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RJ")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "K")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RK")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "L")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RL")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "M")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RM")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "N")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RN")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "O")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RO")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "P")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RP")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "Q")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RQ")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "R")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RR")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "S")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RS")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "T")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RT")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "U")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RU")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "V")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RV")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "W")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RW")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "X")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RX")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "Y")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RY")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }

            if (this.name == "Z")
            {
                IfHasChild();
                if (dispoint.point[j].tag == "LetterPlace" || dispoint.point[j].name == "RZ")
                {
                    this.transform.parent = dispoint.point[j].transform;
                    this.transform.localPosition = Vector3.zero;
                }
                else
                {
                    this.transform.parent = this.transform.parent;
                    this.transform.localPosition = Vector3.zero;
                }
            }
        }

    }

    void IfHasChild()
    {
        if (dispoint.point[j].transform.childCount > 0 && dispoint.point[j].tag == "LetterPlace")
        {
            if (dispoint.point[j].transform.GetChild(0).name == "A")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RA");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "B")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RB");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "C")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RC");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "D")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RD");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "E")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RE");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "F")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RF");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "G")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RG");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "H")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RH");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "I")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RI");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "J")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RJ");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "K")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RK");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "L")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RL");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "M")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RM");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "N")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RN");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "O")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RO");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "P")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RP");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "Q")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RQ");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "R")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RR");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "S")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RS");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "T")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RT");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "U")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RU");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "V")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RV");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "W")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RW");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "X")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RX");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "Y")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RY");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
            else if (dispoint.point[j].transform.GetChild(0).name == "Z")
            {
                Transform parent = dispoint.point[j].transform.parent;
                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;

                GameObject r = GameObject.Find("RZ");
                Transform l = dispoint.point[j].transform.GetChild(0);
                l.position = r.transform.position;
                l.parent = r.transform;
            }
        }
    }

    void PlaceLetter()
    {
        if (this.name == "A")
        {
            this.transform.parent = GameObject.Find("RA").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "B")
        {
            this.transform.parent = GameObject.Find("RB").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "C")
        {
            this.transform.parent = GameObject.Find("RC").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "D")
        {
            this.transform.parent = GameObject.Find("RD").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "E")
        {
            this.transform.parent = GameObject.Find("RE").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "F")
        {
            this.transform.parent = GameObject.Find("RF").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "G")
        {
            this.transform.parent = GameObject.Find("RG").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "H")
        {
            this.transform.parent = GameObject.Find("RH").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "I")
        {
            this.transform.parent = GameObject.Find("RI").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "J")
        {
            this.transform.parent = GameObject.Find("RJ").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "K")
        {
            this.transform.parent = GameObject.Find("RK").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "L")
        {
            this.transform.parent = GameObject.Find("RL").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "M")
        {
            this.transform.parent = GameObject.Find("RM").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "N")
        {
            this.transform.parent = GameObject.Find("RN").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "O")
        {
            this.transform.parent = GameObject.Find("RO").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "P")
        {
            this.transform.parent = GameObject.Find("RP").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "Q")
        {
            this.transform.parent = GameObject.Find("RQ").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "R")
        {
            this.transform.parent = GameObject.Find("RR").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "S")
        {
            this.transform.parent = GameObject.Find("RS").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "T")
        {
            this.transform.parent = GameObject.Find("RT").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "U")
        {
            this.transform.parent = GameObject.Find("RU").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "V")
        {
            this.transform.parent = GameObject.Find("RV").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "W")
        {
            this.transform.parent = GameObject.Find("RW").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "X")
        {
            this.transform.parent = GameObject.Find("RX").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "Y")
        {
            this.transform.parent = GameObject.Find("RY").transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (this.name == "Z")
        {
            this.transform.parent = GameObject.Find("RZ").transform;
            this.transform.localPosition = Vector3.zero;
        }
    }
}
