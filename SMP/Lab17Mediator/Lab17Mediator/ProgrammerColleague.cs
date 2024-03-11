﻿namespace Lab17Mediator;

public class ProgrammerColleague:Colleague
{
    public ProgrammerColleague(Mediator mediator):base(mediator){}

    public override void Notify(string message)
    {
        Console.WriteLine("Съобщение на програмиста: " + 	message);
    }
}