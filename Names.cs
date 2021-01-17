using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Names
    {
        //consrtuct method
        public Names()
        {
            var names = new List<string>();
        }

public void AddName(string name){

    names.Add(name);
    Console.WriteLine($"this is the new name: {name}");
}

        List<string> names = new List<string>();
    }
}