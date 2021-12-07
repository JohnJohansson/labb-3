// using system conects back to the class Console.
using System;

namespace guests
{
    // the main program class
    class Program
    {
        static void Main(string[] args)
        {

            // the guestbook
            guestbook guestbook = new guestbook();
            int i = 0;
            // repets the information 
            while (true)
            {
                // clears the console after new inputs/delete
                Console.Clear();
                Console.WriteLine("J O H N ' S  G Ä S T B O K\n\n");
                // connects to the diffrent switch cases
                Console.WriteLine("1. Gör ett inlägg");
                Console.WriteLine("2. Ta bort ett inlägg\n");
                Console.WriteLine("X. Avsluta programmet\n");

                i = 0;
                // a foreach loop that writes out all the posts with the names
                foreach (construktor posts in guestbook.getguests())
                {
                    Console.WriteLine("Nr: " + "[" + i++ + "] " + "Namn: " + posts.Name + " " + "Inlägg: " + posts.Message);
                }

                int inp = (int)Console.ReadKey(true).Key;

                // the switch case
                switch (inp)
                {
                    case '1':

                        Console.Write("Namn: ");
                        string name = Console.ReadLine();
                        Console.Write("Inlägg: ");
                        string message = Console.ReadLine();
                        var obj = new construktor(name, message);

                        // if the name is null or empty we wont save any info
                        if (String.IsNullOrEmpty(name))
                        {

                        }
                        else
                        {
                            // if the body is null or empty we wont save any info
                            if (String.IsNullOrEmpty(message))
                            {

                            }
                            else
                            {
                                // we only save info if both of them has values
                                guestbook.addpost(obj);
                            }
                        }
                        break;
                    // the second case that lets us delete a post based on its id
                    case '2':

                        Console.Write("Ange index att radera: ");
                        string index = Console.ReadLine();
                        guestbook.delpost(Convert.ToInt32(index));
                        break;
                    case 88:
                        Environment.Exit(0);
                        break;
                }

            }

        }
    }
}