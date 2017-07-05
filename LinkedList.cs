using System;

class MyNode{
    public object nodeValue;
    public MyNode nodePointer;
}

class MyLinkedList
{
    private MyLinkedList _myList;

    private int _size=0;
    MyLinkedList(object value)
    {   
        _size++;
        var node= new MyNode();
        node.nodeValue=value;
        node.nodePointer = null;      
    }

    void Add(object content)
    {
        _size++;
        var newNode= new MyNode(){
            nodeValue= content,
            nodePointer = null
        };
    }

    void AddAtIndex()
    {

    }

    void AddAtFirst()
    {

    }

    void AddAtLast()
    {

    }

    void DeleteAtIndex()
    {

    }

    void Delete()
    {

    }

    void DeleteAtFirst()
    {

    }

    void DeleteAtLast()
    {

    }
}