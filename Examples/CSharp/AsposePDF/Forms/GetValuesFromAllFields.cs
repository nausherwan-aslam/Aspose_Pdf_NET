//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;
using System;

namespace CSharp.AsposePdf.Forms
{
    public class GetValuesFromAllFields
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            //open document
            Document pdfDocument = new Document(dataDir + "GetValuesFromAllFields.pdf");

            //get values from all fields
            foreach (Field formField in pdfDocument.Form)
            {
                Console.WriteLine("Field Name : {0} ", formField.PartialName);
                Console.WriteLine("Value : {0} ", formField.Value);
            }

        }
    }
}