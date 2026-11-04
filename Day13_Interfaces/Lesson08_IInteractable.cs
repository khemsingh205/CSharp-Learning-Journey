using System;
using System.Collections.Generic;

namespace Day13_Lesson08_IInteractable
{
    public interface IInteractable
    {
        void Interact();
    }

    public class Chest : IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("Chest opens! You found 50 gold.");
        }
    }

    public class Door : IInteractable
    {
        private bool isOpen = false;

        public void Interact()
        {
            if (isOpen)
            {
                isOpen = false;
                Console.WriteLine("The door creaks shut.");
            }
            else
            {
                isOpen = true;
                Console.WriteLine("The door creaks open.");
            }
        }
    }

    public class Lesson08Runner
    {
        static void Main()
        {
            List<IInteractable> objects = new List<IInteractable>();
            objects.Add(new Chest());
            objects.Add(new Door());

            foreach (IInteractable item in objects)
            {
                item.Interact();
            }

            Door door = new Door();
            door.Interact();
            door.Interact();

            Console.ReadLine();
        }
    }
}
