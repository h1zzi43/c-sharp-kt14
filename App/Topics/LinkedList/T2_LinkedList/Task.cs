using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App.Topics.LinkedList.T2_LinkedList;

public static class LinkedListTasks
{
    public static LinkedList<int> RemoveDuplicates(LinkedList<int> list)
    {
        if (list == null) 
            throw new ArgumentNullException("list");

        if (list.Count == 1)
            return new LinkedList<int>(list);

        var result = new LinkedList<int>();
        var seenValues = new HashSet<int>();

        
        var currentNode = list.First;
        while (currentNode != null)
        {
            int currentValue = currentNode.Value;

           
            if (!seenValues.Contains(currentValue))
            {
                seenValues.Add(currentValue);
                result.AddLast(currentValue);
            }
             
            currentNode = currentNode.Next;
        }

        return result;
    }
}

    
