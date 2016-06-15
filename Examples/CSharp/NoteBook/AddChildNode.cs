
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    public class AddChildNode
    {
        public static void Run()
        {
            // ExStart:AddChildNode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch �ffnen.onetoc2");

            // Append a new child to the Notebook
            notebook.AppendChild(new Document(dataDir + "Neuer Abschnitt 1.one"));

            dataDir = dataDir + "AddChildNode_out_.onetoc2";

            // Save the Notebook
            notebook.Save(dataDir);
            // ExEnd:AddChildNode
            Console.WriteLine("\nChild node added successfully.\nFile saved at " + dataDir);
        }
    }
}