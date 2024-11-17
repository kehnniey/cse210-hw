using System;
using System.Collections.Generic;
using System.IO;


    public class Journal
    {
        // Attribute: List to store journal entries
        private List<Entry> _entries = new List<Entry>();

        // Method: Add an entry to the journal
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        // Method: Display all entries in the journal
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

        // Method: Save journal entries to a file
        public void Save(string journal.txt)
        {
            using (StreamWriter writer = new StreamWriter(journal.txt))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }
            Console.WriteLine($"\nJournal saved to {journal.txt}.");
        }

        // Method: Load journal entries from a file
        public void Load(string journal.txt)
        {
            if (!File.Exists(journal.txt))
            {
                Console.WriteLine($"\nFile {journal.txt} not found.");
                return;
            }

            _entries.Clear();
            using (StreamReader reader = new StreamReader(journal.txt))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine($"\nJournal loaded from {journal.txt}.");
        }
    }

