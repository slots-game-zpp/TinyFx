﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Demos.Patterns.Behavioral
{
    /// <summary>
    /// 访问者模式
    /// 是封装一些施加于某种数据结构之上的操作。
    /// 一旦这些操作需要修改的话，接受这个操作的数据结构则可以保存不变
    /// </summary>
    internal class VisitorDemo : DemoBase
    {
        public override async Task Execute()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            foreach (Element e in objectStructure.Elements)
            {
                // 每个元素接受访问者访问
                e.Accept(new ConcreteVistor());
            }
        }
    }
    // 抽象元素角色
    public abstract class Element
    {
        public abstract void Accept(IVistor vistor);
        public abstract void Print();
    }

    // 具体元素A
    public class ElementA : Element
    {
        public override void Accept(IVistor vistor)
        {
            // 调用访问者visit方法
            vistor.Visit(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }

    // 具体元素B
    public class ElementB : Element
    {
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }

    // 抽象访问者
    public interface IVistor
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
    }

    // 具体访问者
    public class ConcreteVistor : IVistor
    {
        // visit方法而是再去调用元素的Accept方法
        public void Visit(ElementA a)
        {
            a.Print();
        }
        public void Visit(ElementB b)
        {
            b.Print();
        }
    }

    // 对象结构
    public class ObjectStructure
    {
        private ArrayList elements = new ArrayList();

        public ArrayList Elements
        {
            get { return elements; }
        }

        public ObjectStructure()
        {
            Random ran = new Random();
            for (int i = 0; i < 6; i++)
            {
                int ranNum = ran.Next(10);
                if (ranNum > 5)
                {
                    elements.Add(new ElementA());
                }
                else
                {
                    elements.Add(new ElementB());
                }
            }
        }
    }
}
