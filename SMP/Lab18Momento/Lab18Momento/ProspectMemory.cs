﻿namespace Lab18Momento;

public class ProspectMemory
{
    private Memento _memento;

    public Memento Memento 
    {set { _memento = value; }  get { return _memento; }} 
}