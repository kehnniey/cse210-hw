using System;
using System.Collections.Generic;
using System.IO;

    public class Journal
    {
        // A List to store my journal entries
        private List<Entry> _entries = new List<Entry>();

        // Adding an entry to the journal
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        // Displaying all entries in the journal
        public void Display()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("\nNo journal entries available.");
                return;
            }

            Console.WriteLine("\nJournal Entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }

        // Saving journal entries to a file
        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    // Use public properties to save data
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine($"\nJournal saved to {filename}.");
        }

        // Loading journal entries from a file
        public void Load(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"\nFile {filename} not found.");
                return;
            }

            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        // Create entry using data from file
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine($"\nJournal loaded from {filename}.");
        }
    }

