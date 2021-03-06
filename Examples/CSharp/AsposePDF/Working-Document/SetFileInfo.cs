//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace CSharp.AsposePdf.WorkingDocuments
{
    public class SetFileInfo
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            //open document
            Document pdfDocument = new Document(dataDir + "SetFileInfo.pdf");

            //specify document information
            DocumentInfo docInfo = new DocumentInfo(pdfDocument);

            docInfo.Author = "Aspose";
            docInfo.CreationDate = DateTime.Now;
            docInfo.Keywords = "Aspose.Pdf, DOM, API";
            docInfo.ModDate = DateTime.Now;
            docInfo.Subject = "PDF Information";
            docInfo.Title = "Setting PDF Document Information";

            //save output document
            pdfDocument.Save(dataDir + "SetFileInfo_out.pdf");

            
        }
    }
}