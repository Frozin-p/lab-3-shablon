﻿using sh_lab_3;

using (IReader users = new Reader())
{
    try
    {
        var user = users.ReadLine(2);
        Console.WriteLine(user);
        user = users.ReadLine(1);
        Console.WriteLine(user);
        user = users.ReadLine(0);
        Console.WriteLine(user);
        user = users.ReadLine(1);
        Console.WriteLine(user);
        user = users.ReadLine(3);
        Console.WriteLine(user);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}