using System.Collections.Generic;

//The system IO class is used to to let us write to files and connects back to the class File.
// The class File. lets us open or delete stuff in a file
using System.IO;

using System.Text.Json;

// the name space that connects all the cs files to each other
namespace guests
{
    // a construktor

    // a class for working with the vars from the construktor
    public class guestbook
    {
        // We check if the file exist and put it in a var
        // the @ means we are strickt with what the sign means inside the json string, if itas a X it must be an X and nothig else
        private string json = @"guestbook.json";

        // using list since it automaticly splices togheter the list obejects when adding or removing elements
        private List<construktor> guests = new List<construktor>();

        // check fo the guestbook json file
        public guestbook()
        {
            if (File.Exists(@"guestbook.json") == true)
            { // If stored json data exists then read
                string jsonString = File.ReadAllText(json);
                guests = JsonSerializer.Deserialize<List<construktor>>(jsonString);
            }
        }
        // add post
        public construktor addpost(construktor post)
        {
            guests.Add(post);
            serialize();
            return post;
        }
        // delegate a post
        public int delpost(int index)
        {
            guests.RemoveAt(index);
            serialize();
            return index;
        }
        // guestbook the list of post
        public List<construktor> getguests()
        {
            return guests;
        }
        // serialize
        private void serialize()
        {
            // Serialize all the objects and save to file
            var jsonString = JsonSerializer.Serialize(guests);
            File.WriteAllText(json, jsonString);
        }
    }
}
